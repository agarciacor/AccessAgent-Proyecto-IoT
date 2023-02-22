# Access Agent | Control de Acceso Inteligente
![This is an image](https://raw.githubusercontent.com/agarciacor/AccessAgent-Proyecto-IoT/main/AccessAgent%20C%23/AccessAgentLogoPortada.png)

En la actualidad, la seguridad en el lugar de trabajo es una preocupación importante para las pequeñas empresas. Es por eso que cada vez más empresas están implementando sistemas de control de acceso para proteger sus instalaciones y recursos. Un sistema de control de acceso es una solución de seguridad diseñada para permitir el acceso solo a personas autorizadas a través de dispositivos de identificación como tarjetas de acceso, huellas dactilares o códigos de acceso. Estos sistemas pueden ayudar a prevenir el acceso no autorizado a áreas restringidas, reducir el riesgo de robos y proteger la información confidencial. En este contexto, un sistema de control de acceso para pequeñas empresas es una inversión valiosa que puede brindar tranquilidad y seguridad a los propietarios, empleados y clientes.

**Access Agent** es un sistema hecho como proyecto de IoT (Internet de las cosas) para un curso de [CodigoIoT](https://www.codigoiot.com/), el cual utiliza como protocolo de comunicacion [**MQTT**](https://mqtt.org/) con [Mosquitto](https://mosquitto.org/). Este cuenta con un circuito físico controlado con un programa de [Arduino](https://www.arduino.cc/) en un ESP32CAM (dedicado a la cámara) y un ESP8266 (dedicado a los sensores, actuadores y la comunicación entre el hardware y el sistema).

El circuito cuenta con distintos sensores para aumentar la seguridad del sitio tomando la lectura de la credencial del empleado, video en tiempo real del sujeto y sensor de proximidad para garantizar que se encuentre frente a la cámara

## Objetivo del proyecto
Crear un sistema fácil de usar e implementar para la gestión de entradas y salidas de personal utilizando el internet de las cosas para conectar los dispositivos y centralizarlos en un solo sistema informático.
Dicho sistema espera ser intuitivo y confiable para los encargados de seguridad del lugar.

## Acerca del sistema
- Conexión a base de datos [SQLite](https://www.sqlite.org/index.html)
- Gestión de componentes físicos del sistema
- Programado en C# compatible para plataformas de [Windows](https://www.microsoft.com/es-mx/windows?r=1) (7, 8, 8.1, 10, 11)
- Respuestas inmediatas y buena optimización
- Monitoreo en tiempo real

## Servicios
- Almacenaje de información e historial de accesos
- Fácil manejo y no tiene dependencias
- Monitoreo de cámara de acceso
- No necesita de personal extra
- Respuestas inmediatas

## MQTT
[MQTT](https://mqtt.org/) (Message Queuing Telemetry Transport) es un protocolo de mensajería ligero utilizado para la comunicación entre dispositivos de Internet de las cosas (IoT) y otros sistemas conectados. El protocolo [MQTT](https://mqtt.org/) fue diseñado para ser simple, escalable, confiable y de bajo consumo de energía, lo que lo hace adecuado para dispositivos que tienen recursos limitados, como sensores, actuadores y otros dispositivos IoT.

[MQTT](https://mqtt.org/) utiliza el modelo de publicación/suscripción, lo que significa que los dispositivos pueden publicar datos en un tema (topic) específico y otros dispositivos pueden suscribirse a ese tema para recibir los datos publicados. Los mensajes se entregan de manera asincrónica, lo que permite una mayor eficiencia y reducción de la latencia en comparación con otros protocolos de comunicación.

El protocolo [MQTT](https://mqtt.org/) ha ganado popularidad en la industria de IoT debido a su simplicidad, eficiencia y escalabilidad. Es utilizado por empresas de todo el mundo para conectar y controlar dispositivos IoT, monitorear y recopilar datos, y automatizar procesos en tiempo real.

## Instrucciones de construcción
##### ESP32CAM
Abre el programa de la carpeta [ESP32CAM](https://github.com/agarciacor/AccessAgent-Proyecto-IoT/tree/main/ESP32CAM%20CameraWebServer) con tu Arduino IDE.
Introduce las credenciales la red en la que te encuentras:
```cpp
//Datos de WiFi
const char* ssid = "........";  // Aquí debes poner el nombre de tu red
const char* password = "********";  // Aquí debes poner la contraseña de tu red
```
Carga el programa al ESP32CAM indicando la placa `AI Thinker ESP32-CAM` y el respectivo puerto.

##### ESP8266
Abre el programa de la carpeta [ESP8266](https://github.com/agarciacor/AccessAgent-Proyecto-IoT/tree/main/ESP8266/CodigoESP8266) con tu Arduino IDE.
Introduce las credenciales la red en la que te encuentras:
```cpp
//Datos de WiFi
const char* ssid = "........";  // Aquí debes poner el nombre de tu red
const char* password = "********";  // Aquí debes poner la contraseña de tu red
```
Configura el servidor de broker MQTT introduciendo la IP o dominio y el puerto
```cpp
 client.setServer("test.mosquitto.org", 1883); // Conectarse a la IP del broker en el puerto indicado
```
Carga el programa al ESP8266 indicando la placa `Generic ESP8266 Module` y el respectivo puerto.

##### Sistema Access Agent
Instala y abre [Visual Studio](https://visualstudio.microsoft.com/es/) (preferentemente la versión 2022).
Compila y ejecuta el programa.
Una vez abierto entra al menú de configuración mediante el botón "Configuración" y configura la carpeta de Imagenes (carpeta donde se guardarán las imagenes tomadas por la cámara) y configura la ruta de la base de datos `ControlDeAcceso.db`
