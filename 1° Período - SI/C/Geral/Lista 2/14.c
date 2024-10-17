#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

int  main(){
    
setlocale(LC_ALL, "portuguese");
	
	int a, b, c;

    printf("Digite o primeiro lado do triângulo: ");
    scanf("%d", &a);

    printf("Digite o segundo lado do triângulo: ");
    scanf("%d", &b);

    printf("Digite o terceiro lado do triângulo: ");
    scanf("%d", &c);
    
	if (a < b + c && b < a + c && c < b + a) {
	    
        // Verifica se o triângulo é equilátero
        if (a == b && b == c) {
            printf("O triângulo é equilátero.\n");
        }
        
        // Verifica se o triângulo é isósceles
        else if (a == b || b == c || a == c) {
            printf("O triângulo é isósceles.\n");
        }
        
        // Se não for equilátero ou isósceles, é escaleno
        else {
            printf("O triângulo é escaleno.\n");
        }
        
    } else {
        printf("Os números não podem representar os lados de um triângulo.\n");
    }
}
