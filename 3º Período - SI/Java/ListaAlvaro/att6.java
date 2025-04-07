package alvaro;

import java.util.Scanner;

public class att6 {
    static Scanner scanner = new Scanner(System.in);

    static void tabuada(){
        System.out.print("Digite um valor: ");
        int num = scanner.nextInt();
        
        for(int i = 0; i <= 10; i++){
            int aux = num * i;
            System.out.println(num+" * "+ i +" = "+ aux);
        }
    }
}
