#include <locale.h>
#include <stdlib.h>
#include <stdio.h>

int main()
{
setlocale(LC_ALL, "portuguese");    

    int ano;


    printf("Digite o ano de seu nascimento: ");
    scanf("%d", &ano);

    if(2024 - ano >= 18){
        
        printf("Você pode votar nessa eleição");
    }
    else{
        printf("Você não pode votar nessa eleição");
    }
    
    
    return 0;
}
