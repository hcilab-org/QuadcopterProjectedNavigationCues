#include <Servo.h>
#include <Bridge.h>
#include <YunServer.h>
#include <YunClient.h>

Servo spiegelservo;
YunServer server;


void setup() {
Serial.begin(9600);
  Bridge.begin();
  //dsserver.listenOnLocalhost();
  server.begin();  
spiegelservo.attach(8);
spiegelservo.write(85);
}

void loop() {

  YunClient client = server.accept(); //check new clients

  if(client) {
    String command = client.readString();  //read the incoming data 
    command.trim();
    if (command == "up") {      
        spiegelservo.write(85);
        delay(300);
    }
    if(command == "down"){
        spiegelservo.write(140);
        delay(300);
       }
    if(command == "behind"){
        spiegelservo.write(154);
        delay(300);
       }
    client.print("done");
    client.stop();  
    delay(100);
  }
}
