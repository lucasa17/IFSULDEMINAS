package alvaro;

import java.util.Scanner;

public class att3 {
    static Scanner scanner = new Scanner(System.in);

    static void par(){
        System.out.print("Digite um valor: ");
        int num = scanner.nextInt();
        
        if(num % 2 == 0){
            System.out.println("É par");
        }
        else{
            System.out.println("É ímpar");
        }
    }
}
