#include <stdio.h>

int main()
{
    int codigo, num, codigo1, num1;
    double valor, valor1;
    
    scanf("%d",& codigo);
    scanf("%d",& num);
    scanf("%lf",& valor);
    
    scanf("%d",& codigo1);
    scanf("%d",& num1);
    scanf("%lf",& valor1);

    
        printf("VALOR A PAGAR: R$ %.2lf\n", ( num * valor )+( num1 * valor1 ));


    return 0;
}
