#include <Servo.h>
#include <Bridge.h>
#include <YunServer.h>
#include <YunClient.h>

Servo spiegelservo;
YunServer server;


void setup() {
Serial.begin(9600);
  Bridge.begin();
  //server.listenOnLocalhost();
  server.begin();  
spiegelservo.attach(8);
}

void loop() {
//*********Read new message from the client**************
  YunClient client = server.accept(); //check new clients
   
  if(client) {
    String command = client.readString();  //read the incoming data 
    command.trim();
    if (command == "up") {      
        spiegelservo.write(90);
        delay(300);
       }
       if(command == "down"){
        spiegelservo.write(30);
        delay(300);
       }
    
    client.stop();   
    delay(100);
  }
}
