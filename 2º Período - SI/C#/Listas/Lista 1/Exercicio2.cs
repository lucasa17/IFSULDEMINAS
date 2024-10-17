/*Dado um vetor de n números reais, crie uma função que retorne o maior elemento do vetor, apresente o
vetor.*/

using System;
using Arrays;

    class Exercicio2
    {

        static double maiorVetor(double[] vetor){

        double aux = vetor[0];
        
            for (int i = 0; i < vetor.Length; i++)
            {

                if(aux <= vetor[i]){
                    
                    aux = vetor[i];
                    
                }
                
            }

        return aux;
        }

        static void Main(){

        double[] vetor;

        Console.Write("Digite quantos valores deseja no vetor: ");
        int quant = int.Parse(Console.ReadLine());

        vetor = new double[quant];//declando vetor 

        BibliotecaArray.randomArray(vetor);
        BibliotecaArray.showArray(vetor);


        double resultado = maiorVetor(vetor);        

        Console.WriteLine("\nMaior: "+Math.Round(resultado,2));


    }
}
