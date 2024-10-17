#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

int main()
{
    
setlocale(LC_ALL, "portuguese");

int a, b, c;
    
    printf("Digite três valores interos: ");
    scanf("%i%i%i", &a, &b, &c);
    
    
    printf("Soma: %i", a + b + c);
    

    return 0;
}
