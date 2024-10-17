#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

int  main(){
    
setlocale(LC_ALL, "portuguese");

	int x;
	
	printf("Digite sua idade: ");
	scanf("%i",&x);
	
	if(x < 16){
	    
		printf("Não Eleitor.");
		
	}
	else if(x >= 16 && x < 18 || x > 65){
	    
		printf("Eleitor facultativo.");
		
	}
	else if(x >= 18 && x <= 65){
	    
		printf("Eleitor obrigatório.");
		
	}
}
