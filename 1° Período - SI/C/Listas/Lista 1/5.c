#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

int main()
{
    
setlocale(LC_ALL, "portuguese");

    
    printf("\nPrimeiro ganhador receberá: %.2f reais", 780000 * 0.46);
    
    printf("\nPrimeiro ganhador receberá: %.2f reais", 780000 * 0.32);
    
    printf("\nPrimeiro ganhador receberá: %.2f reais", 780000 * 0.22);

    
    return 0;
}
