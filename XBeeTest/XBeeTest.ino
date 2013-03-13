int x = 0;

void setup() {
  // initialize serial:
  Serial.begin(57600);
}

void loop() {
  delay(100);
  Serial.println(x);
  x++;
}


