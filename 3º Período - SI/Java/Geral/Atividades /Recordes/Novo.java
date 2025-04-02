package novo;

import java.time.*;
import java.util.*;
import java.time.format.DateTimeFormatter;

public class Novo {
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
    
        // leiaRecorde
    public static void lerRecorde(Recorde recorde) {
          System.out.println("Digite o nome do atleta: ");
          leia.nextLine();
          recorde.setNome(leia.nextLine());
          
          System.out.println("Digite a data do recorde (dd/MM/yyyy): ");
          String dataStr = leia.nextLine();
          LocalDate dataFormatada = LocalDate.parse(dataStr,DateTimeFormatter.ofPattern("dd/MM/yyyy"));
          recorde.setDataRecorde(dataFormatada) ;
          System.out.println("Digite o tempo do recorde (em segundos): ");
          recorde.setTempo(leia.nextDouble());
    }

    public static void main(String[] args) {
        int opcao, dado;
        System.out.println("Tamanho da pilha:");
        int tamanho = leia.nextInt();
        Pilha<Recorde> minhaPilha = new Pilha(tamanho);
        
        do{
            opcao = menu();
            switch(opcao){
                case 1:             
                    Recorde novoRecorde = new Recorde();
                    System.out.println("Dados:");
                    lerRecorde(novoRecorde);
                    
                    if(!minhaPilha.isEmpty()){
                        if(novoRecorde.getTempo() < minhaPilha.peek().getTempo()){
                            if(minhaPilha.push(novoRecorde) == true){
                                System.out.println("Item inserido com sucesso");
                                break;
                            }
                            else{
                                System.out.println("Pilha cheia, Item não inserido");
                                break;
                            }
                        }
                    }
                    else{
                        minhaPilha.push(novoRecorde);
                    }
                break;
                case 2: 
                    if(!minhaPilha.isEmpty())
                        System.out.println("Topo removido:"
                                +minhaPilha.pop());
                    else
                    System.out.println("Pilha Vazia!");
                break;
                case 3: 
                    if(!minhaPilha.isEmpty())
                        System.out.println("Topo:"
                                +minhaPilha.peek());
                    else
                    System.out.println("Pilha Vazia!");
                break;
                case 4: 
                    System.out.println(minhaPilha);
                break;
                case 0: 
                    System.out.println("Saindo");
                break;
            }// fim swtich
            leia.nextLine();// pausa
        }while(opcao!=0);
       
    }
    
}
