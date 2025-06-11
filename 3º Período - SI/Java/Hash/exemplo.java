package hash;
import java.util.*;

public class Hash {

    public static void main(String[] args) {
        HashMap<Integer,String> pessoaHash = new HashMap<>();
        ArrayList<Integer> pessoaArray = new ArrayList<>();
        LinkedList<Integer> pesspaLinked = new LinkedList<>();
        int qtdElementos = 100000;
        
        //hash
        long tempoInicial = System.currentTimeMillis();
        for(int i = 0; i < qtdElementos; i++){
            pessoaHash.put(i, "Pessoa"+i);
        }
        for(int i = 0; i < qtdElementos; i++){
            pessoaHash.containsKey(i);
        }
        long tempoFinal = System.currentTimeMillis();
        long tempoTotal = (tempoFinal - tempoInicial)/1000;
        System.out.println("Hash Time: "+ tempoTotal);
        
        
        //array
         tempoInicial = System.currentTimeMillis();
        for(int i = 0; i < qtdElementos; i++){
            pessoaArray.add(i);
        }
        for(int i = 0; i < qtdElementos; i++){
            pessoaArray.contains(i);
        }
        tempoFinal = System.currentTimeMillis();
        tempoTotal = (tempoFinal - tempoInicial)/1000;
        System.out.println("Array Time: "+ tempoTotal);
    }
    
}
