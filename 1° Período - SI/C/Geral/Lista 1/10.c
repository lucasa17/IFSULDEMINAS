#include <stdio.h>

int main()
{
    
    int num, cent, dez, un;
    
    printf("Digite um valor inteiro a ser invertido: ");
    scanf("%d",&num);
    
    cent = num/100;
    
    dez = (num/10)%10;
    
    un = num%10;
    
    
    printf("%d%d%d",un, dez, cent);

    return 0;
}
