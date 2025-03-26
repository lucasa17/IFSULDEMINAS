package pilhajava;

import java.util.*;

public class PilhaJava {

static Scanner leia = new Scanner(System.in);

    private static int menu() {
            
        
            System.out.println("\n--- Menu Pilha ---");
            System.out.println("1. Inserir elemento");
            System.out.println("2. Remover elemento");
            System.out.println("3. Mostrar topo");
            System.out.println("4. Mostrar pilha");
            System.out.println("0. Sair");
            System.out.printf("Digite a opção desejada:" );
        
    return leia.nextInt();
    }
    
    public static void main(String[] args) {
        
        System.out.print("Tamanho da pilha: ");
        int tamanho = leia.nextInt();
        
        Pilha<Integer> minhaPilha = new Pilha(tamanho);

        int op;
        
        do{
            
            op = menu();
            
            switch(op){
                
                case 1:
                    
                    System.out.print("Dado: ");
                    int dado = leia.nextInt();
                    
                    minhaPilha.push(dado);
                
                break;
                
                case 4:
                    
                    System.out.println(minhaPilha);
                
                break;
                
            }
            
        }while(op != 0);
    }
    
}
