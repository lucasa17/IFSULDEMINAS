#include <stdio.h>

int main() {

    int matriz1[3][3];
    int matriz2[3][3];     printf("Digite os valores para a matriz 1:\n");

    
    
    for (int i = 0; i < 3; i++) {
        
        for (int j = 0; j < 3; j++) {
            
            printf("Elemento [%d][%d]: ", i, j);
            scanf("%d", &matriz1[i][j]);
            
        }
        
    }
    
    printf("Digite os valores para a matriz 2:\n");
    
    for (int i = 0; i < 3; i++) {
        
        for (int j = 0; j < 3; j++) {
            
            scanf("%d", &matriz2[i][j]);
            
        }
        
    }


    int matriz3[3][3];
    
    
    for (int i = 0; i < 3; i++) {
        
        for (int j = 0; j < 3; j++) {
            
            printf("Elemento [%d][%d]: ", i, j);

            matriz3[i][j] = matriz2[i][j] + matriz2[i][j];
        }
        
    } 

    printf("\nA soma das matrizes 1 e 2 resulta em:\n");
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            printf("%d ", matriz3[i][j]);
        }
        printf("\n");
    }

    return 0;
}
