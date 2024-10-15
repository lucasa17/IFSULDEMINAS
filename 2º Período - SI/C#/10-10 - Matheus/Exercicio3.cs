/*Dado um vetor de n números reais, crie uma função que retorne o menor elemento do vetor, apresente o
vetor.*/

using System;
using Arrays;

    class Exercicio3
    {

        static double menorVetor(double[] vetor){

        double aux = vetor[0];
        
            for (int i = 0; i < vetor.Length; i++)
            {

                if(aux >= vetor[i]){
                    
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


        double resultado = menorVetor(vetor);        

        Console.WriteLine("\nMenor: "+Math.Round(resultado,2));


    }
}
