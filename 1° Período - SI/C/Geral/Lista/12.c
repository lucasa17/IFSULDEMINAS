#include <stdio.h>
#include <locale.h>

int main()
{

setlocale(LC_ALL,"portuguese");

    float salario, energia, agua, comida, roupa;
    

    printf("Digite seu sálario: ");
    scanf("%f",&salario);
    
    printf("\nDigite seu gasto com energia: ");
    scanf("%f",&energia);
    
    printf("\nDigite seu gasto com água: ");
    scanf("%f",&agua);
    
    printf("\nDigite seu com comida: ");
    scanf("%f",&comida);
    
    printf("\nDigite seu gasto com roupa: ");
    scanf("%f",&roupa);
    
    
    printf("\n\nVocê gasta mensalmente:R$ %.2f", energia + agua + comida + roupa);
    printf("\nDepois de pagar as contas ainda sobram:R$ %.2f", salario - (energia + agua + comida + roupa));

    return 0;
}
