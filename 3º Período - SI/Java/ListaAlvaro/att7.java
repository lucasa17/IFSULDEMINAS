package alvaro;

import java.util.Scanner;

public class att7 {
    static Scanner scanner = new Scanner(System.in);

    static void fibonacci(){        
        System.out.println("Digite um n final");
        int fim = scanner.nextInt();
        
        int aux = 1;
        System.out.println("1");
        for(int i = 0; i <= fim; i++){
            aux = aux+i;
            System.out.println(aux);
        }
    }
}
