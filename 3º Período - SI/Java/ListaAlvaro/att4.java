package alvaro;

import java.util.Scanner;

public class att4 {
    static Scanner scanner = new Scanner(System.in);

    static void fatorial(){
        System.out.print("Digite um valor: ");
        int num = scanner.nextInt();
        
        int aux = 1;
        for(int i = 1; i <= num; i++){
            aux = aux * i; 
        }
        System.out.println("Fatorial de "+ num +" é "+ aux);
    }
}
