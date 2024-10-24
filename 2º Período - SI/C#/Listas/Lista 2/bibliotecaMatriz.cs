using System;

namespace Matrizes
{
    public class bibliotecaMatriz
    {


        public static int[,] makeMatriz(){

            Console.Write("Digite a Quantidade de linhas da matriz: ");
            int linha = int.Parse(Console.ReadLine());

            Console.Write("Digite a Quantidade de linhas da matriz: ");
            int coluna = int.Parse(Console.ReadLine());


            int[,] matriz = new int[linha, coluna];

            for (int i = 0; i < linha; i++)
            {

                for (int j = 0; j < coluna; j++)
                {

                    Console.Write("[" + i + "][" + j + "] = ");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());

                }

            }

            return matriz;
        }

        public static int[,] randomMatriz(){ 

            Console.Write("Digite a Quantidade de linhas da matriz: ");
            int linha = int.Parse(Console.ReadLine());

            Console.Write("Digite a Quantidade de linhas da matriz: ");
            int coluna = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linha, coluna];

            Random random = new Random();

            for (int i = 0; i < linha; i++){

                for (int j = 0; j < coluna; j++){

                    //Console.Write("["+i+"]["+j+"] = ");
                    matriz[i, j] = random.Next(1, 10);

                }

            }

            return matriz;
        }
       public static void showMatriz(int[,] matriz)
        {
            int cont = 0;

            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);

            for (int i = 0; i < linha; i++)
            {

                for (int j = 0; j < coluna; j++)
                {

                    if (cont % coluna == 0)
                    {

                        Console.Write("\n");

                    }

                    Console.Write(matriz[i, j] + "  ");

                    cont++;
                }

            }




        }

        }
    }
