#include <stdio.h>
#include <math.h>

int main() {
    int num, dig;


    printf("Digite um número: ");
    scanf("%d", &num);


    if (num < 0) {
        
        num = -num;
        
    }

    if (num == 0) {
        
        dig = 1;
        
    } else {
        
        dig = (int)log10(num) + 1;
    }

    printf("O número %d possui %d dígito(s).\n", num, dig);

    return 0;
}
