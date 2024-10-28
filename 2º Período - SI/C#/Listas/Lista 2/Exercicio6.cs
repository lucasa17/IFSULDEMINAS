/*Crie uma funC'C#o para calcular e apresentar a soma de 2 matrizes. *Verifique antes se elas sC#o de mesma
ordem.*/

using System;
using Matrizes;


class Exercicio6
{

	static void somaMatriz(int[,] matriz1, int[,] matriz2)
	{

		int linha = matriz1.GetLength(0);
		int coluna = matriz1.GetLength(1);

		int[,] matriz3 = new int[linha, coluna];

		for (int i = 0; i < linha; i++)
		{

			for (int j = 0; j < coluna; j++)
			{

				matriz3[i,j] = matriz1[i,j] + matriz2[i,j];

			}
		}

    bibliotecaMatriz.showMatriz(matriz3);

	}


	static void Main()
	{

		Console.WriteLine("Matriz");

volta:

		Console.WriteLine("Digite o tamanho para a soma de marizes:");

		Console.WriteLine("Obs: Máximo 100\n");

		Console.Write("Digite a Quantidade de linhas da matriz: ");
		int linha = int.Parse(Console.ReadLine());

		Console.Write("Digite a Quantidade de linhas da matriz: ");
		int coluna = int.Parse(Console.ReadLine());

		if (linha > 100 || coluna > 100)
		{
			goto volta;

		}

		int[,] matriz1 = new int[linha, coluna];
		int[,] matriz2 = new int[linha, coluna];

		bibliotecaMatriz.randomMatriz(matriz1);
		bibliotecaMatriz.randomMatriz(matriz2);

		bibliotecaMatriz.showMatriz(matriz1);
		Console.WriteLine();
		bibliotecaMatriz.showMatriz(matriz2);
		Console.WriteLine();

		somaMatriz(matriz1, matriz2);


	}


}
