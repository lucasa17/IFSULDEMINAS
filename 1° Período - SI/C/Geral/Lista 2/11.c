#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

int main()
{
    
    int a, b, c, d, e, f, soma;
    
    printf("Digite 6 valores: ");
    scanf("%d%d%d%d%d%d",&a, &b, &c, &d, &e, &f);
    
    
	if(a > 0){
	    
	soma = soma + a;
	
	}
	if(b > 0){
	    
		soma = soma + b;
		
	}
	if(c > 0){
	    
		soma = soma + c;
		
	}
	
	if(d > 0){
	    
		soma = soma + d;
		
	}
	if(e > 0){
	    
		soma = soma + e;
		
	}
	if(f > 0){
	    
		soma = soma + f;
		
	}
	
	printf("Soma dos positivos deu: %i",soma);
	

    return 0;
}
