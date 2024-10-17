#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <math.h>

int main() {
    int numero, x = 0;
    printf("Digite os números inteiros (0 para encerrar):\n");
    do {
        scanf("%d", &numero);
        if (numero == 50) {
            x++;
        }
    } while (numero != 0);

    printf("O número 50 foi informado %d vezes.\n", x);

    return 0;
}
