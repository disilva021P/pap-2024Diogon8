#include <Servo.h>
#define BOTAO 2
#define MOTOR 3
Servo motor;
void setup()
{
  pinMode(BOTAO,INPUT);
  pinMode(MOTOR,OUTPUT);
  Serial.begin(9600);
  motor.attach(MOTOR);
  motor.write(0);
}

void loop()
{
  if (Serial.available() > 0) {
    String caractereRecebido = Serial.readString();
    int valorInteiro = atoi(caractereRecebido.c_str());
    if(valorInteiro == 0){
      if(motor.read() != 90){
        motor.write(90);
      }
      delay(1000);
    }
    else if(valorInteiro == 1){
      if(motor.read() != 0){
        motor.write(0);
      }
      delay(1000);
    }
  }
 
}