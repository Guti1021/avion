int switchPin1 = 2;  // botones
int switchPin2 = 3;  // botones

int Pin1 = A0; // potenciometros
int Pin2 = A1; // // potenciometros

int data1;
int data2;
int data3;
int data4;

int dato;
int dato2;

void setup()
{
  Serial.begin(9600);
  pinMode(switchPin1, INPUT);  // set digital pin 0 as input
  pinMode(switchPin2, INPUT);  // set digital pin 0 as input

  pinMode(Pin1, INPUT);
  pinMode(Pin2, INPUT);
  
}

void loop()
{
  if (digitalRead(switchPin1) == HIGH) // if the switch is pressed
  {
    dato = 1;      
  }
  else if (digitalRead(switchPin1) == LOW){
    dato = 0;    
    }
  
  if (digitalRead(switchPin2) == HIGH) // if the switch is pressed
  {
    dato2 = 1;
    
  }
  else if (digitalRead(switchPin2) == LOW){
    dato2 = 0;    
    }
    
  
  

  data1 = analogRead(Pin1);
  data2 = analogRead(Pin2);

  data3 = map(data1, 0, 1023, 0, 1000);
  data4 = map(data2, 0, 1023, 0, 1000);

  Serial.print(dato);
  Serial.print(",");
  Serial.print(dato2);
  Serial.print(",");

  Serial.print(data4);
  Serial.print(",");
  Serial.println(data3);
  Serial.flush();
  delay(20);
  
}
