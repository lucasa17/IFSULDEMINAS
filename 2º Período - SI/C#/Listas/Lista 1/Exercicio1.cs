/*Escreva um programa que leia ou gere um vetor de N elementos inteiros (N deve ser informado pelo
usuário) e passe o mesmo como parâmetro para uma função que retorne a soma de seus elementos.*/

using System;
using Arrays;

    class Exercicio1
    {

        static int somaVetor(int[] vetor){

        int soma = 0;

            for (int i = 0; i < vetor.Length; i++)
            {

                soma += vetor[i];

            }

        return soma;
        }

        static void Main(){

        int[] vetor;

        Console.Write("Digite quantos valores deseja no vetor: ");
        int quant = int.Parse(Console.ReadLine());

        vetor = new int[quant];//declando vetor 

        BibliotecaArray.randomArray(vetor);
        BibliotecaArray.showArray(vetor);


        int resultado = somaVetor(vetor);        

        Console.WriteLine("\nSoma: "+resultado);


    }
}
