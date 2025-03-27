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
                    
                    if(minhaPilha.push(dado) == true){
                        System.out.println("Item inserido com sucesso");
                        break;
                    }
                    System.out.println("Pilha cheia, Item não inserido");
                break;
                
                case 2: 
                    if(minhaPilha.isEmpty() == true){
                    System.out.println("\nNão há itens para remover");        
                    break;
                    }
                    System.out.println("\nO item " + minhaPilha.pop() + " foi removido do topo");
                break;
                
                case 3: 
                    System.out.println("\nTopo = " + minhaPilha.peek());  
                break;  
                
                case 4: 
                    System.out.println("\n" + minhaPilha);
                break; 
                
            }
            leia.nextLine();//Pausa
        }while(op != 0);
    } 
}
