#include <stdio.h>

int main()
{
    
    float bits;
    
    
    printf("Digite a quantia de bits: ");
    scanf("%f",&bits);
    
    printf("A quantidade de bytes: %.2f", bits / 8);

    return 0;
}
