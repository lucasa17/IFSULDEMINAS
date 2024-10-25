/*Crie uma função que receba uma matriz N por M e conte quantos números iguais a X existem na matriz. X
deve ser informado pelo usuário (parâmetro da função). Retorne a quantas ocorrências de X existem na
matriz.*/

using System;
using Matrizes;
class Exercicio3
{

    static void encontraMatriz(int[,] matriz)
    {
        int cont = 0;

        int linha = matriz.GetLength(0);
        int coluna = matriz.GetLength(1);

        Console.Write("Digite um valor: ");
        int val = int.Parse(Console.ReadLine());


        for (int i = 0; i < linha; i++)
        {

            for (int j = 0; j < coluna; j++)
            {

                if (val == matriz[i, j])
                {

                    cont++;

                }

            }
        }
        Console.WriteLine("\n\nO valor " + val + " apareceu " + cont + " vezes");

        bibliotecaMatriz.showMatriz(matriz);

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

        encontraMatriz(matriz);


    }


}
