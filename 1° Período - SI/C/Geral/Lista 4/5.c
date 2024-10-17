#include <stdio.h>

int main()
{
  
int num,impar=0,pares=0,somap=0,somai=0;
  
do {
  
printf ("\nDigite um numero ");
scanf ("%d", &num);
  
if (num%2==0) {
  
pares=num;
somap= somap+pares;
  
}
else {
  
impar=num;
somai=somai+impar;
  
}
  
printf ("\nA soma dos numeros pares sera de %d", somap);

printf ("\nA soma dos numeros impares sera de %d", somai);
  
} while (num>=0);
  
return 0;
}
