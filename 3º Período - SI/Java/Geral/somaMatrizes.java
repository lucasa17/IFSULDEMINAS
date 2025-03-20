package aula;

import java.util.Scanner;

public class somaMatrizes {
  
    public static void preencheMatriz(int[][] matriz){
        
        Scanner scanner = new Scanner(System.in);

        for(int i = 0; i < 3; i++){

           for(int j = 0; j < 3; j++){
               
                System.out.print("Elemento [" + i + "][" + j + "]: ");
                matriz[i][j] = scanner.nextInt();               
           }

        }

    }
    
    
    public static int[][] somaMatriz(int[][] matriz1, int[][] matriz2){
        
        int[][] matriz3 = new int[3][3];
        
         for(int i = 0; i < 3; i++){

           for(int j = 0; j < 3; j++){
                              
                matriz3[i][j] = matriz1[i][j] + matriz2[i][j];
                
           }

        }
         
    return matriz3;  
    }
    
    
     public static void imprimeMatriz(int[][] matriz){
        
        for(int i = 0; i < 3; i++){

           for(int j = 0; j < 3; j++){
               
                System.out.print("Elemento [" + i + "][" + j + "]: ");
                System.out.println(matriz[i][j]);
           }

        }

    }
    
    
    
    public static void main(String[] args){
                
        int[][] matriz1 = new int[3][3];
        int[][] matriz2 = new int[3][3];
        int[][] matriz3 = new int[3][3];
        
        System.out.println("Digite a matriz 1:");
        preencheMatriz(matriz1);
        
        System.out.println("\nDigite a matriz 2:");
        preencheMatriz(matriz2);
                
        matriz3 = somaMatriz(matriz1, matriz2);
        
        System.out.println("\nSoma das matrizes:");
        imprimeMatriz(matriz3);

    }
    
}
