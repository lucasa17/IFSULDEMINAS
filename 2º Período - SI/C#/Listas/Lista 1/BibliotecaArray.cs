using System;

namespace Arrays
{

    public class BibliotecaArray
    {

        public static void readArray(int[] vetor)
        {

            Console.WriteLine("\nDigite os valores requisitados:");

            for (int i = 0; i < vetor.Length; i++)
            {
                //Console.Write("[" + i + "]");
                vetor[i] = int.Parse(Console.ReadLine());

            }

        }
        public static void readArray(double[] vetor)
        {

            Console.WriteLine("\nDigite os valores requisitados:");

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("[" + i + "]");
                vetor[i] = double.Parse(Console.ReadLine());

            }

        }
         public static void readArray(char[] vetor)
        {

            Console.WriteLine("\nDigite os valores requisitados:");

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("[" + i + "]");
                vetor[i] = char.Parse(Console.ReadLine());

            }

        }


        public static void randomArray(int[] vetor)
        {

            Random random = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100);

            }
        }
        public static void randomArray(double[] vetor)
        {

            Random random = new Random();

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1, 100) + random.NextDouble();

            }
        }



        public static void showArray(int[] vetor)
        {

            Console.WriteLine("Valores apresentados:");

            for (int i = 0; i < vetor.Length; i++)
            {

                //Console.Write("\t|[" + i + "]|");
                Console.Write("|" + vetor[i] + "|\t");

            }
        }

        public static void showArray(double[] vetor)
        {

            Console.WriteLine("Valores apresentados:");

            for (int i = 0; i < vetor.Length; i++)
            {

                //Console.Write("[" + i + "]");
                Console.WriteLine("|" + Math.Round(vetor[i], 2) + "|\t");

            }
        }
        
        public static void showArray(char[] vetor)
        {

            Console.WriteLine("Caracteres apresentados:");

            for (int i = 0; i < vetor.Length; i++)
            {

                //Console.Write("[" + i + "]");
                Console.Write("|" + vetor[i] + "|\t");

            }
        }

    }
}



