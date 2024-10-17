#include <stdio.h>

int main() {
  
int num,i;
  
printf("Digite um numero: ");
scanf("%d", &num);
  
printf("Multiplos de 3 e 5 ate %d:\n", num);
  
for ( i = 1; i <= num; i++) {
  
if (i % 3 == 0 && i % 5 == 0) {
  
printf("%d\n", i);
  
}
}
  
return 0;
}
