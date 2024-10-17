#include <stdio.h>

int main(){
    
    int t, s, m, h;
    
    scanf("%d", &t);
    
    
h = t/3600;

//printf("\nhoras: %d", h);

m = (t - h*3600)/60; 

//printf("\nminutos: %d", m);

s = t - (m*60 + h*3600);

//printf("\nsegundos: %d", s);

printf("%d:%d:%d", h, m, s);

printf("\n");

    return 0;
}
