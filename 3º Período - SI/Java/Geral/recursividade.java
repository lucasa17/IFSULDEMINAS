package javaapplication1;

import java.util.*;

public class JavaApplication1 {

    static int cont;
    static int contMemo;
    static long[] memoria;
    
    static long fiboMemo(int n){
    contMemo++;
        if(n==0)
            return 0;
        if(n==1)
            return 1;
        if(memoria[n]!=0) // programação dinamica
            return memoria[n];
        long resposta = fiboMemo(n-1)+fiboMemo(n-2);
        memoria[n] = resposta; // programação dinamica
        return resposta;
    }
    
    static long fibo(int n){
        cont++;
        if(n==0)
            return 0;
        if(n==1)
            return 1;
        return fibo(n-1)+fibo(n-2); 
    }
    
    public static void main(String[] args) {
 Scanner leia = new Scanner(System.in);
        System.out.println("Termo de Fibonacci:");
        int n = leia.nextInt();
        memoria = new long[n+1];
        long resp = fiboMemo(n);
        System.out.println("Fibo:"+resp);
        System.out.println("Quantidade de chamadas:"+contMemo);
        
        
        long resposta = fibo(n);
        System.out.println("Fibo:"+resposta);
        System.out.println("Quantidade de chamadas:"+cont);
        
    }
    
}




