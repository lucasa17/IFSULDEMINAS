using System;
using Arrays;

class exercicio1
{

    static void Main()
    {

        Console.WriteLine("Exercicio 1");

        Console.Write("Quantidade de elementos do vetor: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];
        BibliotecaArray.geraVetor(vetor);
        BibliotecaArray.mostraVetor(vetor);


        Console.ReadKey();

    }
}