/*Escreva um programa que leia ou gere um vetor de N elementosinteiros. 
A seguir, crie uma função que receba esse vetor e conte quantos valores impares existem no vetor.
Retorne a quantidade de impares.*/

using System;
using Arrays;

    class Exercicio4
    {

        static int ímparVetor(int[] vetor){

        int cont = 0;
        
            for (int i = 0; i < vetor.Length; i++)
            {

                if(vetor[i]%2 != 0){
                    
                    cont++;
                    
                }
                
            }

        return cont;
        }

        static void Main(){

        int[] vetor;

        Console.Write("Digite quantos valores deseja no vetor: ");
        int quant = int.Parse(Console.ReadLine());

        vetor = new int[quant];//declando vetor 

        BibliotecaArray.randomArray(vetor);
        BibliotecaArray.showArray(vetor);


        int resultado = ímparVetor(vetor);        

        Console.WriteLine("\nÍmpares: "+resultado);


    }
}
