#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <math.h>

int main() {
    int valor, soma = 0, x = 0;

    printf("Digite os valores inteiros positivos (0 para encerrar):\n");

    do {
        scanf("%d", &valor);
        if (valor > 0) {
            soma= soma + valor;
            x++;
        }
    } while (valor != 0);

    if (x > 0) {
        double media = (double)soma / x;
        printf("A media dos valores é: %.2lf\n", media);
    } else {
        printf("Nenhum valor valido foi inserido.\n");
    }

    return 0;
}
