#define trig1 12
#define echo1 8
#define trig2 2
#define echo2 4

unsigned long tempo1;
double distancia1;
unsigned long tempo2;
double distancia2;
void setup()
{
  Serial.begin(9600);
  pinMode(trig1, OUTPUT);
  pinMode(echo1,INPUT);
  pinMode(trig2, OUTPUT);
  pinMode(echo2,INPUT);
}

void loop()
{
	emite_pulso(trig1);
  tempo1 = pulseIn(echo1,HIGH);
  emite_pulso(trig2);
  tempo2 = pulseIn(echo2,HIGH);
  //lugar1
  if (tempo1>0.0){
    distancia1 = 0.034 * tempo1/2.0 /100.0; 
  }
  if (distancia1<1.0){
    Serial.println("1-1");
  }else{
    Serial.println("1-0");
  }
  //lugar2
  if (tempo2>0.0){
    distancia2 = 0.034 * tempo2/2.0 /100.0; 
  }
  if (distancia2<1.0){
    Serial.println("2-1");
  }else{
    Serial.println("2-0");
  }
  delay(1000);
}
void emite_pulso(int porta){
	  digitalWrite(porta,LOW);
  	delayMicroseconds(5);
  	digitalWrite(porta,HIGH);
  	delayMicroseconds(10);
  	digitalWrite(porta,LOW);
}