package alvaro;

import java.util.Scanner;

public class att5 {
    static Scanner scanner = new Scanner(System.in);

    static void maior(){
        System.out.print("Digite um valor: ");
        int num1 = scanner.nextInt();
        System.out.print("Digite outro valor: ");
        int num2 = scanner.nextInt();
        System.out.print("Digite outro valor: ");
        int num3 = scanner.nextInt();
        
        int aux = num1;
        for(int i = 0; i <= 3; i++){
            if(aux <= num1){
                aux = num1;
            }
            if(aux <= num2){
                aux = num2;
            }
            if(aux <= num3){
                aux = num3;
            }
        }
        System.out.println("Maior = "+ aux);
    } 
}
