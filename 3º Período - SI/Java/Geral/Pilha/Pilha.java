package pilhajava;

public class Pilha<T> {
    
    private T[] elementos;
    private int topo;
    
    //Construtor da pilha
    public Pilha(int tamanho){
        
        this.elementos = (T[]) new Object[tamanho];
       
        //(T[]) conversão para o tipo T
        
        //new Object[tamanho] cria nosso vetor a partir do objeto
        
        //se houver um tipo especifico podemos escrever 
        //EX: objeto Car -> elementos = new Car[tamanho]
        
        this.topo = -1;
        
    }
    
    //Checa se o vetor esta vazio
    public boolean isEmpty(){
        
        //Compara e retorna true or false
        return this.topo == -1;
                
    }
    
    //Checa se o vetor esta cheio
    public boolean isFull(){
        
        //Compara e retorna true or false
        return this.elementos.length -1 == this.topo;
        
    }
    
    public boolean push(T dado){
        
        if(!this.isFull()){
            
            this.topo++;
            this.elementos[this.topo] = dado;
            
        return true;  
        }
        
    return false;  
    }
    
    @Override
    public String toString(){
        
        StringBuilder retorno = 
                    new StringBuilder("Topo\n");
        
        for(int i = this.topo; i >= 0; i--){
            
            retorno.append(this.elementos[i] + "\n");
            
        }
    return retorno.toString();   
    }
    
}
