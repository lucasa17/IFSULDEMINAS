/*Escreve um programa que sorteio, aleatoriamente, N números e armazene estes em um vetor. Em seguida, o
usuário digita um número e seu programa em C deve acusar se o número digitado está no vetor ou não. Se
estiver, diga a posição que está.).*/

using System;
using Arrays;

    class Exercicio6
    {

        static int sorteiaVetor(int[] vetor){

            
        Console.WriteLine("\n*****Acerte o número*****");
        Console.WriteLine("obs: você tem 10 chances\n");


        for(int i = 0; i <= 10; i++){
            
            Console.Write("Digite um valor: ");
            int chute = int.Parse(Console.ReadLine());
            
            
            for (int j = 0; j < vetor.Length; j++)
            {

                if(chute == vetor[j]){
                    
                    Console.WriteLine("\nEstá na posição |"+j+"|");
                    
                    return 1;
                }
                else{
                    
                    Console.WriteLine("Não está na posição |"+j+"|");
                    
                }
            
            }
            
        }
        
        return 0;
            
        }

        static void Main(){

        int[] vetor;

        Console.Write("Digite quantos valores deseja no vetor: ");
        int quant = int.Parse(Console.ReadLine());

        vetor = new int[quant];//declando vetor 

        BibliotecaArray.randomArray(vetor);
        

        int aux = sorteiaVetor(vetor);
        
        
        if(aux == 1){
            
            Console.WriteLine("Parabéns você acertou");

        }
        else{
            
            Console.WriteLine("\nAcabaram suas chances, não foi dessa vez");

        }

    }
}
