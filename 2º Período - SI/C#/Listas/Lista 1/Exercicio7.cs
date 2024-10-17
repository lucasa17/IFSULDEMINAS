/*Escreva um programa que leia ou gere dois vetores de N posições e faça a multiplicação dos elementos de
mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.*/

using System;
using Arrays;

    class Exercicio7
    {

        static void multiplicaVetor(int[] vetor1, int[] vetor2){


        int[] vetorFinal;
        
        vetorFinal = new int[vetor1.Length];
        
        
            for (int i = 0; i < vetor1.Length; i++)
            {

               vetorFinal[i] = vetor1[i] * vetor2[i];
               
            }
            
        BibliotecaArray.showArray(vetor1);
        BibliotecaArray.showArray(vetor2);
        BibliotecaArray.showArray(vetorFinal);
            
        }
            
            
    

        static void Main(){

        int[] vetor1;
        int[] vetor2;


        Console.Write("Digite quantos valores deseja nos vetores: ");
        int quant = int.Parse(Console.ReadLine());

        vetor1 = new int[quant];//declando vetor 
        vetor2 = new int[quant];//declando vetor


        BibliotecaArray.randomArray(vetor1);
        BibliotecaArray.randomArray(vetor2);
        

        multiplicaVetor(vetor1, vetor2);        



    }
    
}

