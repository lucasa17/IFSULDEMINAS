package javarecordscontrol;

import java.util.*;

public class Pilha<T> implements Iterable<T>{
    private T[] elementos;
    private int topo;
    
   public Pilha(int tamanho){
        this.elementos = (T[]) new Object[tamanho];
        this.topo = -1;
    }
    public Pilha(){
        this.elementos = (T[]) new Object[10];
        this.topo = -1;
    }
    public boolean isEmpty(){
        return this.topo == -1;
        
       /* if(this.topo == -1)
            return true;
        else
            return false;*/
    }
    
    public boolean isFull(){
        return this.topo == this.elementos.length -1;
    }
    
    
    public boolean push(T dado){
        if(this.isFull()){
            aumentaCapacidade();
        }
            this.elementos[++this.topo] = dado;
    return true;
    }
    
    public T pop(){
       // T dado = this.elementos[this.topo];
       // this.topo--;
       // return dado;
        return this.elementos[this.topo--];
    }
    
    public T peek(){
       // T dado = this.elementos[this.topo];
       // return dado;
        return this.elementos[this.topo];
    }
    
    private void aumentaCapacidade() {
        if (this.isFull()) { 
            T[] elementosNovos = (T[]) new Object[this.elementos.length * 2]; 
            for(int i = 0; i < this.elementos.length; i++) {
                elementosNovos[i] = this.elementos[i]; 
            
        }
        this.elementos = elementosNovos;
        }
    }
    
    @Override
    public String toString(){
        
        StringBuilder retorno =
                new StringBuilder("\n");
        for(int i = this.topo ; i>=0; i--)
            retorno.append(this.elementos[i]+"\n");
        
        return retorno.toString();
    }
    
    @Override
    public Iterator<T> iterator(){
        return new PilhaIterator();
    }
    
    private class PilhaIterator implements Iterator<T>{
        private int atual = topo;
        
        @Override
        public boolean hasNext(){
            return atual >= 0;
            /*if(atual >= 0){
                return true;
            }
            else{
                return false;
            }*/
        }
        
        @Override
        public T next(){
            return elementos[atual--];
            /*T dado = elementos[atual];
            atual--;
            return dado;*/
        }
    }
    
}