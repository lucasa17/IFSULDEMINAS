package teste;


public class Teste {

    
    static int addVelocidade(int velocidade){
        
        velocidade++;
        
        System.out.println("Velocidade na função: "+ velocidade);
       
    return velocidade;
    }
    
    
    static void addVelocidadeCar(Car carro){
        
        int novaVelocidade = carro.velocidadeAtual();
        
        novaVelocidade++;
        
        carro.alteraVelocidade(novaVelocidade);
        
        System.out.println("\nVelocidade atual alterada na função: "+novaVelocidade);
    }
    
    
    static void alteraNome(String novoNome){
        
        novoNome += " Silva";
        
        System.out.println("\nNome na função: "+novoNome);
        
    }
    
    public static void main(String[] args) {

        Car novoCarro = new Car();//novoCarro se torna objeto pois recebe referencia de Car
                
        Car novaCarroca = new Car();//novoCarro se torna objeto pois recebe referencia de Car

            novoCarro.alteraVelocidade(10);
            
            novaCarroca.alteraVelocidade(15);
                                
        System.out.println("Velocidade do novoCarro: "+ novoCarro.velocidadeAtual());

            int velocidade = addVelocidade(novoCarro.velocidadeAtual());
        
        System.out.println("Velocidade retornada pela função: "+velocidade);

        System.out.println("Velocidade fora da função: "+novoCarro.velocidadeAtual());
        
            addVelocidadeCar(novoCarro);
            
        System.out.println("Velocidade fora da nova função: "+novoCarro.velocidadeAtual());

            addVelocidadeCar(novaCarroca);

        System.out.println("Velocidade fora da nova função: "+novaCarroca.velocidadeAtual());

        
        
        String nome = "Lucas";
        
        alteraNome(nome);
        
        System.out.println("Nome fora da função: "+nome);

    }
    
}
