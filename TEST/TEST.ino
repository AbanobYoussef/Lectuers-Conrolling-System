int led1=13,led2=12,val;
void setup() {
  // put your setup code here, to run once:
pinMode(led1,OUTPUT);
pinMode(led2,OUTPUT);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
val=Serial.read();
  switch(val)
  {
   case '1':
   digitalWrite(led1,HIGH);
   delay(4000);
   digitalWrite(led1,LOW);
   digitalWrite(led2,HIGH);
   delay(4000);
   digitalWrite(led2,LOW);
   break;
   case '2':
   digitalWrite(led1,HIGH);
   delay(4000);
   digitalWrite(led1,LOW);
   break;
   case '3':
   digitalWrite(led2,HIGH);
   delay(4000);
   digitalWrite(led2,LOW);
   break;
   case '4':
   delay(4000);
   digitalWrite(led2,HIGH);
   delay(4000);
   digitalWrite(led2,LOW);
   break;
  }
}
