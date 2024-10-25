/*Escrever um programa que gere uma matriz de N Linhas x N Colunas e apresente sua diagonal secundária.*/

using System;
using Matrizes;

class Exercicio5
{

    static void diagonalSecMatriz(int[,] matriz)
    {

        int linha = matriz.GetLength(0);
        int coluna = matriz.GetLength(1);

        int contj = coluna-1;

        Console.WriteLine("\n");
        for (int i = 0; i < linha; i++)
        {

            for (int j = 0; j < coluna; j++)
            {

                if (contj == j)
                {

                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "\t");
                }

            }
            contj--;
        }


    }


    static void Main()
    {

        Console.WriteLine("Matriz");


    volta:

        Console.WriteLine("Obs: Máximo 100");

        Console.Write("Digite a Quantidade de linhas da matriz: ");
        int linha = int.Parse(Console.ReadLine());

        Console.Write("Digite a Quantidade de linhas da matriz: ");
        int coluna = int.Parse(Console.ReadLine());

        if (linha > 100 || coluna > 100)
        {
            goto volta;

        }

        int[,] matriz = new int[linha, coluna];

        bibliotecaMatriz.randomMatriz(matriz);

        bibliotecaMatriz.showMatriz(matriz);

        diagonalSecMatriz(matriz);


    }


}
