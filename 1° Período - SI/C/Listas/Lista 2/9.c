#include <locale.h>
#include <stdlib.h>
#include <stdio.h>

int main()
{
setlocale(LC_ALL, "portuguese");    

    char letra;


    printf("Digite uma letra maiúscula: ");
    scanf("%c", &letra);

    if(letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U'){
        
        printf("%c é uma vogal", letra);
    }
    else{
        printf("%c é uma consoante", letra);
    }
    
    
    return 0;
}
