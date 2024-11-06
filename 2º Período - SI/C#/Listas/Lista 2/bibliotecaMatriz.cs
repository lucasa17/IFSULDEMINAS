using System;

namespace Matrizes
{
    public class bibliotecaMatriz
    {


        public static void makeMatriz(int[,] matriz){

            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);

            for (int i = 0; i < linha; i++)
            {

                for (int j = 0; j < coluna; j++)
                {

                    Console.Write("[" + i + "][" + j + "] = ");
                    matriz[i,j] = int.Parse(Console.ReadLine());

                }

            }

        }
        public static void makeMatriz(double[,] matriz)
        {

            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);

            for (int i = 0; i < linha; i++)
            {

                for (int j = 0; j < coluna; j++)
                {

                    Console.Write("[" + i + "][" + j + "] = ");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                }

            }

        }


        public static void randomMatriz(int[,] matriz)
        {

            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);

            Random random = new Random();

            for (int i = 0; i < linha; i++){

                for (int j = 0; j < coluna; j++){

                    //Console.Write("["+i+"]["+j+"] = ");
                    matriz[i, j] = random.Next(1, 10);

                }

            }
        }
        public static void randomMatriz(double[,] matriz)
        {

            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);

            Random random = new Random();

            for (int i = 0; i < linha; i++)
            {

                for (int j = 0; j < coluna; j++)
                {

                    //Console.Write("["+i+"]["+j+"] = ");
                    matriz[i, j] = random.Next(1, 10);

                }

            }
        }

                public static void randomMatriz100(int[,] matriz)
        {

            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);

            Random random = new Random();

            for (int i = 0; i < linha; i++)
            {

                for (int j = 0; j < coluna; j++)
                {

                    //Console.Write("["+i+"]["+j+"] = ");
                    matriz[i, j] = random.Next(1, 100);

                }

            }
        }
        
        public static void randomMatriz100(double[,] matriz)
        {

            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);

            Random random = new Random();

            for (int i = 0; i < linha; i++)
            {

                for (int j = 0; j < coluna; j++)
                {

                    //Console.Write("["+i+"]["+j+"] = ");
                    matriz[i, j] = random.Next(1, 100);

                }

            }
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

                    Console.Write($"{matriz[i, j],3}  ");

                    cont++;
                }

            }
        }
        public static void showMatriz(double[,] matriz)
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

                    Console.Write($"{matriz[i, j],3}  ");

                    cont++;
                }

            }
        }




    }
    }
