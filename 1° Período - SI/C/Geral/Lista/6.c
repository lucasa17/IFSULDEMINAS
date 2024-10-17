#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

int main()
{
    
setlocale(LC_ALL, "portuguese");

    int d; 
    
    printf("Digite quantos dias foram trabalhados: ");
    scanf("%d", &d);
    
    
    printf("\nDeverá ser pago ao encanador: %.2f reais", (30 * d) * 0.92);
    
    
    return 0;
}
