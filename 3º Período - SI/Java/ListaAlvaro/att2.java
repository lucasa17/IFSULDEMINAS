package alvaro;

import java.util.Scanner;

public class att2 {
    static Scanner scanner = new Scanner(System.in);

    static void soma(){
        System.out.print("Digite um valor: ");
        int num1 = scanner.nextInt();
        System.out.print("Digite outro valor: ");
        int num2 = scanner.nextInt();
        System.out.println("Soma: " + (num1 + num2));
    }
}
