/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package teste;

/**
 *
 * @author 41279517883
 */
public class Teste {

    
    public static void main(String[] args) {

        Car novoCarro = new Car();//novoCarro se torna objeto pois recebe referencia de Car
        
        Car novoCarro2 = novoCarro;//novoCarro2 é um ponteiro, apenas copia novoCarro

            novoCarro.alteraVelocidade(10);
                
        System.out.println("Velocidade do novoCarro: "+ novoCarro.velocidadeAtual());
        
            novoCarro2.alteraVelocidade(20);
        
        System.out.println("Velocidade do novoCarro2: "+ novoCarro2.velocidadeAtual());

        System.out.println("Velocidade do novoCarro: "+ novoCarro.velocidadeAtual());

    }
    
}
