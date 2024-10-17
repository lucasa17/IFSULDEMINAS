#include <stdlib.h>
#include <stdio.h>
#include <math.h>
#include <locale.h>

int main()
{
    
setlocale(LC_ALL, "portuguese");

float a;
    
    printf("Digite um valor: ");
    scanf("%f", &a);
    
    
    printf("Resultado: %.2f", pow(a,2));
    

    return 0;
}
