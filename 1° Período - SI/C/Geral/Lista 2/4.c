#include <stdio.h>
#include <math.h>
#include <locale.h>

int main()
{
    
setlocale(LC_ALL, "portuguese");


    int pessoas;
    
    printf("Digite um valor: ");
    scanf("%d",&pessoas);
    
    
    if(pessoas <= 1000){
        
        printf("Público baixo");
        
    }
    
    else if(pessoas >= 1001 && pessoas <= 10000){
        
        printf("Público médio");
    }
    
    else{
        printf("Público bom");
    }

    return 0;
}
