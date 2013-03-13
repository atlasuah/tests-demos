#include <Servo.h>
#include <Wire.h>
#include "compassFunctions.h"

float heading = 0.0;

void setup()
{
  CompassSetup();
  heading = getHeading();
  
  Serial.begin(57600);
  while (!Serial){;}
}

void loop()
{
  Serial.println(heading);
  delay(50);
  heading = getHeading();
}
