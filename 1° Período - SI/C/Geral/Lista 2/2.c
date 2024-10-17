#include <stdio.h>
#include <math.h>
#include <locale.h>

int main()
{
    
setlocale(LC_ALL, "portuguese");


    int n;
    
    printf("Digite um valor: ");
    scanf("%d",&n);
    
    
    if(n % 5 == 0){
        
        printf("O valor %d é multiplo de 5", n);
        
    }
    else{
        
        printf("Valor não é multiplo de 5");
    }

    return 0;
}
