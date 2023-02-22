#include <SPI.h>
#include <MFRC522.h> //Biblioteca para el RFID

#include <ArduinoJson.hpp>
#include <ArduinoJson.h> //Bibliotecas de JSON

#include <ESP8266WiFi.h> // Biblioteca para el control de WiFi
#include <PubSubClient.h> //Biblioteca para conexion MQTT

//Datos de WiFi
const char* ssid = "........";  // Aquí debes poner el nombre de tu red
const char* password = "********";  // Aquí debes poner la contraseña de tu red

//Datos del broker MQTT
const char* mqtt_server = "test.mosquitto.org"; // Si estas en una red local, coloca la IP asignada, en caso contrario, coloca la IP publica

// Objetos
WiFiClient espClient; // Este objeto maneja los datos de conexion WiFi
PubSubClient client(espClient); // Este objeto maneja los datos de conexion al broker

// RFID
#define SS_PIN 15
#define RST_PIN 16
MFRC522 rfid(SS_PIN, RST_PIN); // Instance of the class
MFRC522::MIFARE_Key key;
// Init array that will store new NUID
byte nuidPICC[4];


// SENSOR DE PROXIMIDAD
const int Trigger = 5;   //Pin digital 2 para el Trigger del sensor
const int Echo = 4;   //Pin digital 3 para el echo del sensor

// RELEVADOR
const int Relevador = 2;

// LED RGB
const int Red = 9;
const int Green = 0;
const int Blue = 10;

void setup() { 
  Serial.begin(9600);

  WiFi.begin(ssid, password); // Esta es la función que realiz la conexión a WiFi
    while (WiFi.status() != WL_CONNECTED) { // Este bucle espera a que se realice la conexión
    //digitalWrite (ledPin, HIGH);
    delay(500); //dado que es de suma importancia esperar a la conexión, debe usarse espera bloqueante
    //digitalWrite (ledPin, LOW);
    Serial.print(">");  // Indicador de progreso
    delay (5);
  }

  Serial.println();
  Serial.println("WiFi conectado");
  Serial.println("Direccion IP: ");
  Serial.println(WiFi.localIP());

  delay (1000); // Esta espera es solo una formalidad antes de iniciar la comunicación con el broker

  // Conexión con el broker MQTT
  client.setServer("test.mosquitto.org", 1883); // Conectarse a la IP del broker en el puerto indicado
  client.setCallback(callback); // Activar función de CallBack, permite recibir mensajes MQTT y ejecutar funciones a partir de ellos
  delay(1500);  // Esta espera es preventiva, espera a la conexión para no perder información



  //-------------------------------------------------------- RFID
 	SPI.begin(); // Init SPI bus
 	rfid.PCD_Init(); // Init MFRC522

 	rfid.PCD_DumpVersionToSerial();
 	for (byte i = 0; i < 6; i++) {
 			key.keyByte[i] = 0xFF;
 	}

  //------------------------------------------SENSOR PROXIMIDAD

  pinMode(Trigger, OUTPUT); //pin como salida
  pinMode(Echo, INPUT);  //pin como entrada
  digitalWrite(Trigger, LOW);//Inicializamos el pin con 0

  //------------------------------------------RELEVADOR
  pinMode(Relevador, OUTPUT);  //pin como salida
  digitalWrite(Relevador, LOW);//Inicializamos el pin con 0

  //------------------------------------------LED
  pinMode(Red, OUTPUT);
  pinMode(Green, OUTPUT);
  pinMode(Blue, OUTPUT);

  digitalWrite(Red,HIGH);
  digitalWrite(Green,HIGH);
  digitalWrite(Blue,HIGH);
}
void loop() {

  //Verificar siempre que haya conexión al broker
  if (!client.connected()) {
    
    reconnect();  // En caso de que no haya conexión, ejecutar la función de reconexión, definida despues del void setup ()
  }// fin del if (!client.connected())
  client.loop(); // Esta función es muy importante, ejecuta de manera no bloqueante las funciones necesarias para la comunicación con el broker

 	// Restablece el ciclo si no hay ninguna tarjeta nueva presente en el sensor/lector. Esto guarda todo el proceso cuando está inactivo.
 	if ( ! rfid.PICC_IsNewCardPresent())
 			return;
 	// Verificar si el ID ya fue leida
 	if ( ! rfid.PICC_ReadCardSerial())
 			return;
       
 	MFRC522::PICC_Type piccType = rfid.PICC_GetType(rfid.uid.sak);

 	// Checar el tipo de PICC de la tarjeta
 	if (piccType != MFRC522::PICC_TYPE_MIFARE_MINI &&
 					piccType != MFRC522::PICC_TYPE_MIFARE_1K &&
 					piccType != MFRC522::PICC_TYPE_MIFARE_4K) {
 			Serial.println(F("La tarjeta no es del tipo MIFARE Classic."));
 			return;
 	}
 	if (rfid.uid.uidByte[0] != nuidPICC[0] ||
 					rfid.uid.uidByte[1] != nuidPICC[1] ||
 					rfid.uid.uidByte[2] != nuidPICC[2] ||
 					rfid.uid.uidByte[3] != nuidPICC[3] ) {
 			// Guarda NUID en el arreglo nuidPICC
 			for (byte i = 0; i < 4; i++) {
 					nuidPICC[i] = rfid.uid.uidByte[i];
 			}

      long t; //timpo que demora en llegar el eco
      long distanciaCM; //distancia en centimetros

      digitalWrite(Trigger, HIGH);
      delayMicroseconds(10);   //Enviamos un pulso de 10us
      digitalWrite(Trigger, LOW);
      
      t = pulseIn(Echo, HIGH); //obtenemos el ancho del pulso
      distanciaCM = t/59;      //escalamos el tiempo a una distancia en cm



 			//--------------------------------------JSON
      String json = CrearJSON(
        ObtenerHexRFID(rfid.uid.uidByte, rfid.uid.size),
        distanciaCM
      );
      Serial.print(json);

      int str_len = json.length() + 1;//Se calcula la longitud del string
      char char_array[str_len];//Se crea un arreglo de caracteres de dicha longitud
      json.toCharArray(char_array, str_len);//Se convierte el string a char array    
      client.publish("accessAgent/Lecturas/RFID", char_array); // Esta es la función que envía los datos por MQTT, especifica el tema y el valor

      
 	}
 	else Serial.println(F("Card read previously."));
 	// Halt PICC
 	rfid.PICC_HaltA();
 	// Stop encryption on PCD
 	rfid.PCD_StopCrypto1();
}
/**
 		Helper routine to dump a byte array as hex values to Serial.
*/
String ObtenerHexRFID(byte *buffer, byte bufferSize) {
  String hexRFID = "";
 	for (byte i = 0; i < bufferSize; i++) {
      hexRFID += String(buffer[i], HEX) + " ";
 	}
  hexRFID.toUpperCase();
  //Serial.print(hexRFID);
  hexRFID.trim();
  return hexRFID;
}
/**
 		Helper routine to dump a byte array as dec values to Serial.
*/
void printDec(byte *buffer, byte bufferSize) {
 	for (byte i = 0; i < bufferSize; i++) {
 			Serial.print(buffer[i] < 0x10 ? " 0" : " ");
 			Serial.print(buffer[i], DEC);
 	}
}

String CrearJSON(String LecturaRFID, int DistanciaCM)
{
    String json;
    StaticJsonDocument<300> doc;
    doc["LecturaRFID"] = LecturaRFID;
    doc["DistanciaCM"] = DistanciaCM;
    serializeJson(doc, json);

    return json;
}

void callback(char* topic, byte* message, unsigned int length) {

  // Indicar por serial que llegó un mensaje
  Serial.print("Llegó un mensaje en el tema: ");
  Serial.print(topic);

  // Concatenar los mensajes recibidos para conformarlos como una varialbe String
  String messageTemp; // Se declara la variable en la cual se generará el mensaje completo  
  for (int i = 0; i < length; i++) {  // Se imprime y concatena el mensaje
    Serial.print((char)message[i]);
    messageTemp += (char)message[i];
  }
  // Se comprueba que el mensaje se haya concatenado correctamente
  Serial.println();
  Serial.print ("Mensaje concatenado en una sola variable: ");
  Serial.println (messageTemp);

  // En esta parte puedes agregar las funciones que requieras para actuar segun lo necesites al recibir un mensaje MQTT

  // El NodeMCU está suscrito al tema esp/output
  if (String(topic) == "accessAgent/Lecturas/RFID_INPUT") {  // En caso de recibirse mensaje en el tema

    if(messageTemp == "$ACTIVAR_RELEVADOR"){
      Serial.println("Comando $ACTIVAR_RELEVADOR");
      digitalWrite(Relevador, HIGH);   // activar el rele'
      delay(2000);               // esperar 2 segundos
      digitalWrite(Relevador, LOW);    // apagar el rele'
    }

    if(messageTemp == "$OTORGAR_ACCESO"){
      Serial.println("Comando $OTORGAR_ACCESO");
      digitalWrite(Relevador, HIGH);   // activar el rele'
      digitalWrite(Red, HIGH);
      digitalWrite(Green, LOW);
      digitalWrite(Blue, HIGH);
      delay(6000);               // esperar 2 segundos
      digitalWrite(Relevador, LOW);    // apagar el rele'
      digitalWrite(Red, HIGH);
      digitalWrite(Green, HIGH);
      digitalWrite(Blue, HIGH);
    }

    if(messageTemp == "$ACTIVAR_LED_R"){
      Serial.println("Comando $ACTIVAR_LED_R");
      digitalWrite(Red, LOW);
      digitalWrite(Green, HIGH);
      digitalWrite(Blue, HIGH);
      delay(2000);               // esperar 2 segundos
      digitalWrite(Red, HIGH);
      digitalWrite(Green, HIGH);
      digitalWrite(Blue, HIGH);
    }

    if(messageTemp == "$ACTIVAR_LED_G"){
      Serial.println("Comando $ACTIVAR_LED_G");
      digitalWrite(Red, HIGH);
      digitalWrite(Green, LOW);
      digitalWrite(Blue, HIGH);
      delay(2000);               // esperar 2 segundos
      digitalWrite(Red, HIGH);
      digitalWrite(Green, HIGH);
      digitalWrite(Blue, HIGH);
    }

    if(messageTemp == "$ACTIVAR_LED_B"){
      Serial.println("Comando $ACTIVAR_LED_B");
      digitalWrite(Red, HIGH);
      digitalWrite(Green, HIGH);
      digitalWrite(Blue, LOW);
      delay(2000);               // esperar 2 segundos
      digitalWrite(Red, HIGH);
      digitalWrite(Green, HIGH);
      digitalWrite(Blue, HIGH);
    }

  }// fin del if (String(topic) == "esp32/output")
}// fin del void callback

void reconnect() {
  // Bucle hasta lograr conexión
  while (!client.connected()) { // Pregunta si hay conexión
    // Intentar reconexión
    if (client.connect("ESP8266Client")) { //Pregunta por el resultado del intento de conexión
      //Serial.println("Conectado");
      client.subscribe("accessAgent/Lecturas/RFID_INPUT"); // Esta función realiza la suscripción al tema
    }// fin del  if (client.connect("ESP8266Client"))
    else {  //en caso de que la conexión no se logre
      Serial.print("Conexion fallida, Error rc=");
      Serial.print(client.state()); // Muestra el codigo de error
      Serial.println(" Volviendo a intentar en 5 segundos");
      // Espera de 5 segundos bloqueante
      delay(5000);
      Serial.println (client.connected ()); // Muestra estatus de conexión
    }// fin del else
  }// fin del bucle while (!client.connected())
}// fin de void reconnect(