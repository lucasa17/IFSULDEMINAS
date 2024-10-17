#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

int main()
{
    
setlocale(LC_ALL, "portuguese");

    int cigarros, anos;
    float total;
    
    printf("Digite quantos cigarros são fumados por dia: ");
    scanf("%d", &cigarros);
    
    printf("Digite quantos anos você é fumante: ");
    scanf("%d", &anos);
    
    total = (anos * 365) * cigarros;
    
    total = total / 144;
    
    printf("\nSão %.2f dias de vida a menos", total);
    
    
    return 0;
}
