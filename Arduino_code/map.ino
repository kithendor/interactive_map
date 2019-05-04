int agglia = 3;
int ellada = 5;
int italia = 4;
int germania = 6;
int roumania = 7;
int souidia = 8;
int tsexia = 9;
int gallia = 10;
int rossia = 11;
int ollandia = 12;
int ispania = 13;

int led1 = 2;
int led2 = 1;
int led3 = 0;

int led4 = 14;
int led5 = 15;
int led6 = A2;
int led7 = 16;
int led8 = 17;
int led9 = 18;

int leds[8] = {0,1,2,14,15,16,17,18};


void setup() {
  pinMode(agglia,INPUT);
  pinMode(ellada,INPUT); 
  pinMode(italia,INPUT);
  pinMode(germania,INPUT);
  pinMode(roumania,INPUT);
  pinMode(souidia,INPUT);
  pinMode(tsexia,INPUT);
  pinMode(gallia,INPUT);
  pinMode(rossia,INPUT);
  pinMode(ollandia,INPUT);
  pinMode(ispania,INPUT);

  pinMode(led1,OUTPUT);
  pinMode(led2,OUTPUT);
  pinMode(led3,OUTPUT);
  pinMode(led4,OUTPUT);
  pinMode(led5,OUTPUT);
 pinMode(led6,OUTPUT);
 pinMode(led7,OUTPUT);
 pinMode(led8,OUTPUT);
 pinMode(led9,OUTPUT);
 Serial.begin(9600);
 

}

void loop() {
  if(digitalRead(agglia)==1)
  {
    Serial.println("gb");
    
  }
  if(digitalRead(ellada)==1)
  {
    Serial.println("gr");
    ledcontrol(2);
  }
  if(digitalRead(italia)==1)
  {
    Serial.println("it");
    ledcontrol(3);
  }
    if(digitalRead(germania)==1)
  {
    Serial.println("ger");
    ledcontrol(4);
  }
    if(digitalRead(roumania)==1)
  {
    Serial.println("rom");
    ledcontrol(5);
  }
    if(digitalRead(souidia)==1)
  {
    Serial.println("sw");
    ledcontrol(6);
  }
    if(digitalRead(tsexia)==1)
  {
    Serial.println("ch");
    ledcontrol (7);
  }
    if(digitalRead(gallia)==1)
  {
    Serial.println("fra");
    ledcontrol (8);
  }
    if(digitalRead(rossia)==1)
  {
    Serial.println("rus");
    
  }
    if(digitalRead(ollandia)==1)
  {
    Serial.println("ned");
  }
    if(digitalRead(ispania)==1)
  {
    Serial.println("sp");
  
  }
}

void ledcontrol(int x)
{
  digitalWrite(leds[x],HIGH);
  for(int i=0;i<8;i++)
  {
    if(i==x)
      continue;
    digitalWrite(leds[i], LOW);
  }
}

