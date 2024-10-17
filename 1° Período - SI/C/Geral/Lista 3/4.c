#include <stdio.h>
#include <locale.h>

int main()
{

setlocale(LC_ALL, "portuguese");

    int a, soma; 
    
    for(int x = 1; x <= 10; x++){
        
        printf("Digite um valor: ");
        scanf("%d", &a);
        
        if(a %2 != 0){
            
            soma += a;
        }
        
    }
    
    printf("Soma dos ímpares: %d", soma);

    return 0;
}
