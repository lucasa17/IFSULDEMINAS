#include <stdio.h>

int main() {
  
int num, soma = 0;
  
printf("Digite um numero: ");
scanf("%d", &num);
  
for (int i = 1; i <= num / 2; i++) {
  
if (num % i == 0) {
  
soma += i;
  
}
}

if (soma == num) {
  
printf("%d é um numero perfeito.\n", num);
  
} 
else {
printf("%d nao é um numero perfeito.\n", num);
}
  
return 0;
}
