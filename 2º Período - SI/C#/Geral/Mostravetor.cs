using System;

class program
{

    static void Main(){


        int[] vetor1 = new int[5];//declando vetor

        Console.WriteLine("Digite os valores requisitados:");

        for(int i = 0; i < vetor1.Length; i++)
        {

            vetor1[i] = int.Parse(Console.ReadLine());

        }

        Console.WriteLine("\nValores recebidos:");

        for (int i = 0; i < vetor1.Length; i++)
        {

            Console.WriteLine(vetor1[i]);

        }
        }
}
