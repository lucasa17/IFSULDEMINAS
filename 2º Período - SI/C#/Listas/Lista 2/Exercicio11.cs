using System;
using Matrizes;
class Exercicio11
{

    static int somaDiagonalMatriz(int[,] matriz)
    {

        int somaDP = 0;

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

                    somaDP = somaDP + matriz[i, j];

                }

            }
        }

    return somaDP;
    }


    static int somaDiagonalSecMatriz(int[,] matriz)
    {

        int linha = matriz.GetLength(0);
        int coluna = matriz.GetLength(1);

        int contj = coluna - 1;

        int somaDS = 0;

        Console.WriteLine("\n");
        for (int i = 0; i < linha; i++)
        {

            for (int j = 0; j < coluna; j++)
            {

                if (contj == j)
                {

                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "\t");

                    somaDS = somaDS + matriz[i, j];

                }

            }
            contj--;
        }

        return somaDS;
    }



    static void Main()
    {

        Console.WriteLine("Matriz");

    volta:

        Console.WriteLine("Obs: Máximo 100 e deve ser quadrada");

        Console.Write("Digite a Quantidade de linhas da matriz: ");
        int linha = int.Parse(Console.ReadLine());

        Console.Write("Digite a Quantidade de colunas da matriz: ");
        int coluna = int.Parse(Console.ReadLine());

        if (linha > 100 || coluna > 100)
        {
            goto volta;

        }

        int[,] matriz = new int[linha, coluna];

        bibliotecaMatriz.randomMatriz(matriz);

        bibliotecaMatriz.showMatriz(matriz);

        int somaDP = somaDiagonalMatriz(matriz);

        int somaDS = somaDiagonalSecMatriz(matriz);


        Console.Write("\n\nSoma Diagonal Principal: " + somaDP + "\nSoma Diagonal Sécundaria: " + somaDS);
    }


}
