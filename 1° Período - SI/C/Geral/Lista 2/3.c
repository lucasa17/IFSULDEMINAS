#include <stdio.h>
#include <math.h>
#include <locale.h>

int main()
{
    
setlocale(LC_ALL, "portuguese");

    int idade;
    
    printf("Digite sua idade: ");
    scanf("%d",&idade);
    
    
    if(idade >= 18 && idade <= 67){
        
        printf("Você pode doar sangue");
        
    }
    else{
        
        printf("Valor não pode doar sangue");
    }

    return 0;
}
