/*Crie uma função que receba uma matriz de N Linhas x M Colunas valores inteiros e retorne qual o maior
valor da matriz.*/

using System;
using Matrizes;

class Exercicio1
{

    static void maiorMatriz(int[,] matriz){

        int linha = matriz.GetLength(0);
        int coluna = matriz.GetLength(1);

        int maior = matriz[0,0];

        for (int i = 0; i < linha; i++)
        {

            for (int j = 0; j < coluna; j++)
            {

                if (maior <= matriz[i, j])
                {

                    maior = matriz[i, j];

                }

            }
        }
    Console.WriteLine("\n\nMaior valor: "+maior);
    }


        static void Main()
    {

        Console.WriteLine("Matriz");

        int[,] matriz = bibliotecaMatriz.randomMatriz();

        bibliotecaMatriz.showMatriz(matriz);

        maiorMatriz(matriz);


    }

}

