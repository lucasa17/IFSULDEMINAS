#include <math.h>
#include <stdio.h>

int main()
{
    float a, b, c;
    
    printf("Digite o valor de A: ");
    scanf("%f",&a);
    
    printf("\nDigite o valor de B: ");
    scanf("%f",&b);
    
    c = pow(a,2) + pow(b,2);
    
    printf("A hipotenusa vale: %.2f", sqrt(c));
    

    return 0;
}
