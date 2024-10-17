#include <stdio.h>
#include <locale.h>
#include <math.h>

int main()
{
    
setlocale(LC_ALL, "portuguese");

    float a; 
    
    for(int x = 0; x <= 15; x++){

        printf("3 ^ %d = %.2f \n", x, pow(3,x));
        
    }
    

    return 0;
}
