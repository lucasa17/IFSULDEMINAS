#include <stdlib.h>
#include <stdio.h>
#include <locale.h>

int main()
{
    
setlocale(LC_ALL, "portuguese");

float dis, vel;
int h, m;
    
    printf("Digite a distância: ");
    scanf("%f", &dis);
    
    printf("\nDigite a velocidade média: ");
    scanf("%f", &vel);
    
h = dis/vel;

m =  ((dis/vel)*60) - (h * 60); 
    
    
    printf("Resultado: %ih:%im", h, m);
    

    return 0;
}
