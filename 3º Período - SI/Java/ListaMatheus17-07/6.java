import java.util.*;

public class Recursiva {
    static Scanner leia = new Scanner(System.in);
    static int cont = 0;
    static long rec(int n, int m){
      cont++;
        if(n == 1){
          return m + 1;
        }
        if(m == 1){
          return n + 1;
        }
        return rec(m, n - 1) + rec(m - 1, n);
      
    }
    
    public static void main(String[] args) {
        System.out.println("Escreva um número: ");
        int primeiroNum = leia.nextInt();
        System.out.println("Escreva outro número: ");
        int segundoNum = leia.nextInt();
        long respo = rec(primeiroNum,segundoNum);
        System.out.println("Resposta: "+respo);
        System.out.println("Vezes que a função foi chamada: " + cont);
    }
    
}
