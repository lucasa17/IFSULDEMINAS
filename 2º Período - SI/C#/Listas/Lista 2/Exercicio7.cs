/*FaC'a um programa que leia ou gere duas matrizes N X M de mesma ordem com valores reais. OfereC'a ao
usuC!rio um menu de opC'C5es: (a) somar as duas matrizes (b) subtrair a primeira matriz da segunda (c)
adicionar uma constante as duas matrizes (d) imprimir as matrizes.
Nas duas primeiras opC'C5es uma terceira matriz deve ser criada. Na terceira opC'C#o o valor da constante deve
ser lido e o resultado da adiC'C#o da constante deve ser armazenado na própria matriz.*/

using System;
using Matrizes;


class Exercicio7
{

    static double[,] somaMatriz(double[,] matriz1, double[,] matriz2)
    {

        int linha = matriz1.GetLength(0);
        int coluna = matriz1.GetLength(1);

        double[,] matriz3 = new double[linha, coluna];

        for (int i = 0; i < linha; i++)
        {

            for (int j = 0; j < coluna; j++)
            {

                matriz3[i, j] = matriz1[i, j] + matriz2[i, j];

            }
        }

        return matriz3;
    }


    static double[,] subtraiMatriz(double[,] matriz1, double[,] matriz2)
    {

        int linha = matriz1.GetLength(0);
        int coluna = matriz1.GetLength(1);

        double[,] matriz4 = new double[linha, coluna];

        for (int i = 0; i < linha; i++)
        {

            for (int j = 0; j < coluna; j++)
            {

                matriz4[i, j] = matriz1[i, j] - matriz2[i, j];

            }
        }

        return matriz4;
    }

    static void AdicionaConstante(double[,] matriz, double constante)
    {

        int linha = matriz.GetLength(0);
        int coluna = matriz.GetLength(1);


        for (int i = 0; i < linha; i++)
        {

            for (int j = 0; j < coluna; j++)
            {

                matriz[i, j] = matriz[i, j] + constante;


            }
        }

    }


    static void Main()
    {

        Console.WriteLine("Matriz");

    volta:

        Console.WriteLine("\nDigite o tamanho para a soma de marizes:");

        Console.WriteLine("Obs: Máximo 100\n");

        Console.Write("Digite a Quantidade de linhas da matriz: ");
        int linha = int.Parse(Console.ReadLine());

        Console.Write("Digite a Quantidade de linhas da matriz: ");
        int coluna = int.Parse(Console.ReadLine());

        if (linha > 100 || coluna > 100)
        {
            goto volta;

        }

        double[,] matriz1 = new double[linha, coluna];
        double[,] matriz2 = new double[linha, coluna];
        double[,] matriz3 = new double[linha, coluna];
        double[,] matriz4 = new double[linha, coluna];


        bibliotecaMatriz.randomMatriz(matriz1);
        bibliotecaMatriz.randomMatriz(matriz2);

        bool condSoma = false;
        bool condSub = false;
        bool cond = true;

        while (cond == true)
        {

            Console.WriteLine("\n------------------------------");

            Console.WriteLine("1 - somar as duas matrizes \n2 - subtrair a primeira matriz da segunda \n3 - adicionar uma constante nas duas matrizes \n4 - imprimir matrizes");
            Console.Write("obs: Digite qualquer outra tecla para sair.\n");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {

                case 1:

                    matriz3 = somaMatriz(matriz1, matriz2);

                    condSoma = true;

                    Console.Clear();

                    break;

                case 2:

                    matriz4 = subtraiMatriz(matriz1, matriz2);

                    condSub = true;

                    Console.Clear();

                    break;

                case 3:

                    Console.Write("Digite a constante a ser adicionada: ");
                    double constante = double.Parse(Console.ReadLine());

                    AdicionaConstante(matriz1, constante);
                    AdicionaConstante(matriz2, constante);

                    Console.WriteLine("Constante adicionada");

                    Console.Clear();

                    break;

                case 4:

                    Console.Clear();

                    if (condSoma == true && condSub == true)
                    {

                        Console.Write("\nMatriz 1:");
                        bibliotecaMatriz.showMatriz(matriz1);
                        Console.WriteLine();

                        Console.Write("\nMatriz 2:");
                        bibliotecaMatriz.showMatriz(matriz2);
                        Console.WriteLine();

                        Console.Write("\nMatriz Soma:");
                        bibliotecaMatriz.showMatriz(matriz3);
                        Console.WriteLine();

                        Console.Write("\nMatriz Subtraída:");
                        bibliotecaMatriz.showMatriz(matriz4);
                        Console.WriteLine();

                    }
                    else if (condSoma == true && condSub == false)
                    {

                        Console.Write("\nMatriz 1:");
                        bibliotecaMatriz.showMatriz(matriz1);
                        Console.WriteLine();

                        Console.Write("\nMatriz 2:");
                        bibliotecaMatriz.showMatriz(matriz2);
                        Console.WriteLine();

                        Console.Write("\nMatriz Soma:");
                        bibliotecaMatriz.showMatriz(matriz3);
                        Console.WriteLine();

                    }
                    else if (condSoma == false && condSub == true)
                    {

                        Console.Write("\nMatriz 1:");
                        bibliotecaMatriz.showMatriz(matriz1);
                        Console.WriteLine();

                        Console.Write("\nMatriz 2:");
                        bibliotecaMatriz.showMatriz(matriz2);
                        Console.WriteLine();

                        Console.Write("\nMatriz Subtraída:");
                        bibliotecaMatriz.showMatriz(matriz4);
                        Console.WriteLine();

                    }
                    else
                    {

                        Console.Write("\nMatriz 1:");
                        bibliotecaMatriz.showMatriz(matriz1);
                        Console.WriteLine();

                        Console.Write("\nMatriz 2:");
                        bibliotecaMatriz.showMatriz(matriz2);
                        Console.WriteLine();

                    }

                    break;

                default:

                    cond = false;

                    break;

            }

        }



    }


}
