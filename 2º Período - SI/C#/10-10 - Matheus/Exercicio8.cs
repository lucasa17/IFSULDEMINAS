/*Leia um vetor de caracteres. Utilize a função Length para obter a quantidade de elementos do vetor de
caracteres. Escreva o vetor lido em ordem inversa.*/

using System;
using Arrays;

class Exercicio8
{

    static void inverteVetor(char[] vetor1)
    {

        Console.Write("\n\n");
        
        for (int i = vetor1.Length-1; i >= 0; i--)
        {
            
                Console.Write("|" + vetor1[i] + "|\t");
            
        }

        
    }

    static void Main()
    {

        char[] vetor1;


        Console.Write("Digite quantos caracteres deseja: ");
        int quant = int.Parse(Console.ReadLine());

        vetor1 = new char[quant];//declando vetor 


        BibliotecaArray.readArray(vetor1);
        BibliotecaArray.showArray(vetor1);


        inverteVetor(vetor1);



    }

}

