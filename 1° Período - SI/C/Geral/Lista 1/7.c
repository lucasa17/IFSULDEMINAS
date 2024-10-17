#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

int main()
{
    
setlocale(LC_ALL, "portuguese");

    int ml350, ml600, ml2000; 
    
    printf("Digite quantas latas de 350ml foram compradas: ");
    scanf("%d", &ml350);
    
    printf("Digite quantas garrafas de 600ml foram compradas: ");
    scanf("%d", &ml600);
    
    printf("Digite quantas garrafas de 2 litros foram compradas: ");
    scanf("%d", &ml2000);
    
    
    
    printf("\nSão %.2f litros", (ml350 * 0.35) + (ml600 * 0.60) + (ml2000 * 2));
    
    
    return 0;
}
