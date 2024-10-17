#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

int main()
{
    
setlocale(LC_ALL, "portuguese");

float des, mer;

    
    printf("Digite o valor da mercadoria: ");
    scanf("%f", &mer);
    
    printf("\nDigite o desconto: ");
    scanf("%f", &des);
    
    
    printf("\nDesconto total: %.2f", (mer/100)*des);
    
    printf("\nValor final: %.2f", mer - ((mer/100)*des));
    

    return 0;
}
