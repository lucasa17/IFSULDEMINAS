int botao1 = 2;
int botao2 = 3;
int botao3 = 4;
int botao4 = 5;
int botao5 = 6;
int botao6 = 7;
int botao7 = 8;

int buzzer = 9;

void setup() {
  pinMode(botao1, INPUT);
  pinMode(botao2, INPUT);
  pinMode(botao3, INPUT);
  pinMode(botao4, INPUT);
  pinMode(botao5, INPUT);
  pinMode(botao6, INPUT);
  pinMode(botao7, INPUT);
  pinMode(buzzer, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  int status1 = digitalRead(botao1);
  int status2 = digitalRead(botao2);
  int status3 = digitalRead(botao3);
  int status4 = digitalRead(botao4);
  int status5 = digitalRead(botao5);
  int status6 = digitalRead(botao6);
  int status7 = digitalRead(botao7);

  Serial.println(status1);

  if (status1 == 1) { //Se o botão 1 for pensionado
    tone(buzzer, 262); //Toca nota Dó
    delay(200); //por 200 milissegundos
    noTone(buzzer); //Interrompe o som
  }
  if (status2 == 1) { //Se o botão 2 for pressionado
    tone(buzzer, 294); //Toca nota Ré
    delay(200); //por 200 milissegundos
    noTone(buzzer); //Interrompe o som
  }
  if (status3 == 1) { //Se o botão 3 for pressionado
    tone(buzzer, 330); //Toca nota Mi
    delay(200); //por 200 milissegundos
    noTone(buzzer); //Interrompe o som
  }
  if (status4 == 1) { //Se o botão 4 for pressionado
    tone(buzzer, 349); //Toca nota Fá
    delay(200); //por 200 milissegundos
    noTone(buzzer); //Interrompe o som
  }
  if (status5 == 1) { //Se o botão 5 for pressionado
    tone(buzzer, 392); //Toca nota Sol
    delay(200); //por 200 milissegundos
    noTone(buzzer); //Interrompe o som
  }
  if (status6 == 1) { //Se o botão 6 for pressionado
    tone(buzzer, 440); //Toca nota Lá
    delay(200); //por 200 milissegundos
    noTone(buzzer); //Interrompe o som
  }
  if (status7 == 1) { //Se o botão 7 for pressionado
    tone(buzzer, 493); //Toca nota Si
    delay(200); //por 200 milissegundos
    noTone(buzzer); //Interrompe o som
  }
}
