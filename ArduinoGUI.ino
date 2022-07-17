#include "DHT.h"                    //Library for DHT22 sensor
#include <Servo.h>

#define SERVO_PIN 9                  //Pin 9 spojen servo motor
Servo myservo ;

#define GROUND_JOY_PIN A3            //joystick ground pin will connect to Arduino analog pin A3
#define VOUT_JOY_PIN A2              //joystick +5 V pin will connect to Arduino analog pin A2
#define XJOY_PIN A1                  //X axis reading from joystick will go into analog pin A1

#define DHTpin 4                     //Pin za prijenos podataka odnosno data pin za DHT senzor je 4
#define DHTTYPE DHT22
DHT dht (DHTpin,DHTTYPE);

//Joystick
int value;
int EventVal;
const int SW_pin = 8;
int bValue = 0 ;                     // Vrijednost koju čita button 
int joystickXVal;

//Button
int LEDState=0;
int LEDpin = 7;
int buttonPin = 12;
int buttonNEW;
int buttonOLD=1;

// Motor
int LED_SerialState_Pin = 10;
int LEDState_Motora = 0;

//Humidity
int State_SensorHUM = 0;

//Char check
char QuestionChar;

void setup()
{
 Serial.begin(115200);
 pinMode(VOUT_JOY_PIN, OUTPUT) ;    //pin A2 shall be used as output
 pinMode(GROUND_JOY_PIN, OUTPUT) ;  //pin A3 shall be used as output
 digitalWrite(VOUT_JOY_PIN, HIGH) ; //set pin A2 to high (+5V)
 digitalWrite(GROUND_JOY_PIN,LOW) ; //set pin A3 to low (ground)
 pinMode(LED_SerialState_Pin,OUTPUT);   //Za debuggiranje Porta/da li je komunikacija spojena ili ne.
 pinMode(LEDpin,OUTPUT);
 pinMode(buttonPin,INPUT);
 myservo.attach(SERVO_PIN);
 pinMode(SW_pin, INPUT);
 digitalWrite(SW_pin, HIGH);
 dht.begin();
}
void VlaznostFun(){
     float h = dht.readHumidity(); // Gets the values of the humidity
    Serial.print("Humidity = ");
    Serial.print(h);
    Serial.println(" % ");
    Serial.println("");
    delay(1000);
}

void loop()
{///#################    Senzor Vlage DHT22      ################///////////////
  
QuestionChar=Serial.read();
if(QuestionChar == '3')
  {
  VlaznostFun();
  }
//***################################# Arduino - C# Pali/Gasi Motor ##############################//////
//receiveVal_NEW = Serial.read(); 
else if(QuestionChar=='1')
{
  if(LEDState_Motora == 0)
  {
  digitalWrite(LED_SerialState_Pin,HIGH);
  LEDState_Motora = 1;
  }
else
  {
  digitalWrite(LED_SerialState_Pin,LOW);
  LEDState_Motora = 0;
  }
  delay(100);
}
//*****################################ Zatvori Port ############################################## 
else if (QuestionChar =='4')
{
    digitalWrite(LED_SerialState_Pin,LOW);
    digitalWrite(LEDpin,LOW);
    LEDState_Motora = 0;
    LEDState=0;
}
///################### PushButton as Toggle Switch(Sklopa)##############/////

    buttonNEW=digitalRead(buttonPin);
    if((buttonOLD == 0 && buttonNEW == 1))
     {
      if(LEDState == 0)                    //Ledica je izagasena u tom trenutku. zato cemo u nastavku je promjenit jer se mjenja stanje
       {   
        digitalWrite(LEDpin,HIGH);
        LEDState = 1;
      }
      else
      {
        digitalWrite(LEDpin,LOW);
        LEDState=0;
      }
     }    
    buttonOLD=buttonNEW;
    delay(100);
///###################  Joystick Naredbe ##############3////////////////
 
    bValue = digitalRead(SW_pin);
    if(bValue==1 && LEDState==1 && LEDState_Motora == 1)
    {   
      joystickXVal = analogRead(XJOY_PIN) ;           //read joystick input on pin A1//
      value = map(joystickXVal,0,1023,0,180);         //u vrijednost value sprema se pozicija joysticka u okvirima pomaka i kuta.//Ova naredba određuje poziciju!
      myservo.write(value);
      delay(25); 
    }

    else if(bValue==0 && LEDState==0 && LEDState_Motora == 0)
    {
     // if(receiveVal=='0'){
      value = map(joystickXVal,0,1023,0,180);         //u vrijednost value sprema se pozicija joysticka u okvirima pomaka i kuta.
      myservo.write(value);
      delay(25);
    }
}
