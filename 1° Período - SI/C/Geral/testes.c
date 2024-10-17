#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <math.h>
 

int main() {

setlocale(LC_ALL, "portuguese");

    const float pi = 3.14;
	int a, d;
	float b, c;
	char nome = 'L';

	printf("%c", nome);
	a = 5;
	b = 10.5;
	c = a + b;

    	printf("\na: %i",a);
    	printf("\nb: %.2f",b);
    	printf("\nc: %.2f",c);

        	printf("\n\nDigite a: ");
        	scanf("%d",& a);
        	
        	printf("Digite b: ");
        	scanf("%f",& b);
        
            printf("\na: %i",a);
    	    printf("\nb: %.2f",b);
        	printf("\nc: %.2f", a + b);
        	
        	
        	    printf("\nDigite oos valores de A e B:\t");
        	    scanf("%d%f",&a,&b);
        	    
        	    printf("\na: %i",a);
    	        printf("\nb: %.2f",b);
                printf("\nc: %.2f", a + b);
                
                    printf("\n\nDigite um valor:");
                    scanf("%d",&d);
                    
                    printf("A raiz de %d é %f",d, sqrt(d));

        
	return 0;
}
