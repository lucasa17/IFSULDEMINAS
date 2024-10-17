#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

int main()
{
    
    float val1 = 19.50, imposto = 0.90;
    
	int h;
	
	printf("Escreva a quantidade de horas trabalhadas: ");
	scanf("%i",&h);
	

	if(val1 * h > 1500.00){
	    
		printf("Imposto aplicado\n");
		printf("Salário líquido R$ %f", (val1 * h) * imposto);

	}
	
    return 0;
}
