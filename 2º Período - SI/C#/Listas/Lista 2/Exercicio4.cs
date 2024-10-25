/*Escrever um programa que gere uma matriz de N Linhas x N Colunas e apresente sua diagonal principal.
Dica, limite sua matriz a uma ordem 100.*/

using System;
using Matrizes;
class Exercicio4
{

    static void diagonalMatriz(int[,] matriz)
    {

        int cont = 0;

        int linha = matriz.GetLength(0);
        int coluna = matriz.GetLength(1);

        Console.WriteLine("\n");
        for (int i = 0; i < linha; i++)
        {

            for (int j = 0; j < coluna; j++)
            {

                if (i == j)
                {

                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "\t");
                }

            }
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

        diagonalMatriz(matriz);


    }


}
