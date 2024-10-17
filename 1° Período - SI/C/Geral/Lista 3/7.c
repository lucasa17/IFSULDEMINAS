#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <math.h>

int main() {
    
	double nota, soma = 0, maiorNota = 0;
	int contador = 0, i = 0;

	printf("Digite as notas das disciplinas (valor negativo para encerrar):\n");

    while(nota >= 0){
 
i++;      
		printf("Nota da disciplina %d: ", i);
		scanf("%lf", &nota);

		if (nota >= 0) {
			soma += nota;
			contador++;

			if (nota > maiorNota) {
				maiorNota = nota;
			}
		} else {
			printf("Nota invalida. Encerrando a entrada.\n");
			
		}
	}

	if (contador > 0) {
		double media = soma / contador;
		printf("Media das notas: %.2f\n", media);
		printf("Maior nota: %.2f\n", maiorNota);
	} else {
		printf("Nenhuma nota valida foi inserida.\n");
	}

	return 0;
}
