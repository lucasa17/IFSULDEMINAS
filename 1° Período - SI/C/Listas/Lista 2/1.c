#include <stdio.h>
#include <math.h>
#include <locale.h>

int main()
{
    
setlocale(LC_ALL, "portuguese");


    float n;
    
    printf("Digite um valor: ");
    scanf("%f",&n);
    
    
    if(n > 0){
        
        printf("A raiz é %.2f", sqrt(n));
        
    }
    else{
        
        printf("Valor inválido");
    }

    return 0;
}
