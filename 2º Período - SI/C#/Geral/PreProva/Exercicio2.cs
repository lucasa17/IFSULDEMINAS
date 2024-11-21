using System;
using Biblioteca_Matriz;

class exercicio2
{

    static void Main()
    {

        Console.WriteLine("Exercicio 2");

        Console.Write("Quantidade de linhas da matriz: ");
        int linha = int.Parse(Console.ReadLine());

        Console.Write("Quantidade de colunas da matriz: ");
        int coluna = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linha,coluna];

        Matriz.gera(matriz);
        Matriz.mostra(matriz);


        Console.ReadKey();

    }
}