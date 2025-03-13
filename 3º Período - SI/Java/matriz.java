import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        // Declarar as matrizes
        int[][] matriz1 = new int[3][3];
        int[][] matriz2 = new int[3][3];

        // Preenchendo a matriz 1
        System.out.println("Digite os valores para a matriz 1:");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                System.out.print("Elemento [" + i + "][" + j + "]: ");
                matriz1[i][j] = sc.nextInt();
            }
        }

        // Preenchendo a matriz 2
        System.out.println("Digite os valores para a matriz 2:");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                System.out.print("Elemento [" + i + "][" + j + "]: ");
                matriz2[i][j] = sc.nextInt();
            }
        }

        // Soma das matrizes
        int[][] matriz3 = new int[3][3];
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                matriz3[i][j] = matriz1[i][j] + matriz2[i][j];
            }
        }

        // Exibindo o resultado da soma
        System.out.println("\nA soma das matrizes 1 e 2 resulta em:");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                System.out.print(matriz3[i][j] + " ");
            }
            System.out.println();
        }

        // Fechar o scanner
        sc.close();
    }
}
