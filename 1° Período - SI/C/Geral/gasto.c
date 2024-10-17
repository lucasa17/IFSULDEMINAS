#include <stdio.h>

int main(){
    
    int tempo, vel;
    
    float aux;

    scanf("%d %d", &tempo, &vel);
    
aux = tempo * vel;

printf("%.3f\n", aux/12);

    return 0;
}
