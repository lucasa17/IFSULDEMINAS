#include <stdio.h>
#include <stdlib.h>
#include <time.h>


void gera(int *v, int n){
	
	int i;
	
	printf("Endereço do vetor na função: %x \n", v);
	
	srand(time(NULL));
    
    for(i = 0; i < n; i++){
    	
    	v[i] = rand()%10;
    		
	}
	
}

int main()
{
    int i;
    
    int n;
    
    int *vet;
    
    printf("Tamanho do vetor:");
    scanf("%d",&n);
    
    vet = malloc(sizeof(int)*n);//alocando
    
    gera(vet, n);
	
	for(i = 0; i < n; i++){
		
		printf("vet[%d]:%d \n", i, vet[i]);
		
	}
	
	printf("Endereço de vetor: %x \n", vet);
	
	for(i = 0; i < n; i++){
	
	printf("Endereço de vetor[%d]: %x \n", i, &vet[i]);

	}
	
	getch();// pausa
    
    return 0;
}
