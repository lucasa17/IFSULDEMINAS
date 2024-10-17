#include <stdio.h>

int main() {

int num, i, j, divisores;

float media, soma = 0, quant = 0;

printf("Digite um número: ");
scanf("%d", &num);

for (i = 2; i <= num; i++) {

divisores = 0;

for (j = 1; j <= i; j++) {

if (i % j == 0) {

divisores++;

}
}

if (divisores == 2) {

soma = soma+i;
quant++;

}
}

media = soma / quant;

printf("A média dos números primos menores ou iguais a %d é: %.2f\n", num,
media);

return 0;
}
