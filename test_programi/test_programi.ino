void setup() {
  Serial.begin(115200);
}

void loop() {
int time =10;
//Pil similasyon
int hucre_belirle = random(200,220);
int volt = random(3000,4200);
String veri = "719365," + String(hucre_belirle)+ "," +String(volt); 
Serial.println(veri);
delay(time);
//sicaklik seviyesi
int sicaklik_belirle = random(300,305);
int sicaklik = random(0,999);
veri = "719365," + String(sicaklik_belirle)+ "," +String(sicaklik); 
Serial.println(veri);
delay(time);
//akım degeri
int akim = random(-3000,3000);
veri = "719365,400,"; 
Serial.print(veri);
Serial.println(akim);
delay(time);
//devir
int devir = random(0,6000);
veri = "719365,500," +String(devir); 
Serial.println(veri);
delay(time);
//hiz
int hiz = random(0,180);
veri = "719365,501," +String(hiz); 
Serial.println(veri);
delay(time);
}
