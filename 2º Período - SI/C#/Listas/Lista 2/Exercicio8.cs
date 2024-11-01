using System;
using Matrizes;


class Exercicio8
{


    static void Main()
    {

        Console.WriteLine("Matriz");

    volta:

        Console.WriteLine("\nDigite a quantidade de raios:");
        Console.Write("Obs: Máximo 500000 e Minimo 2\n");

        int raios = int.Parse(Console.ReadLine());

        if (raios < 2 || raios > 500000)
        {   
            Console.Clear();
            goto volta;

        }


        int[,] matriz = new int[501, 501];


        for (int i = 0; i < 501; i++)
        {

            for (int j = 0; j < 501; j++)
            {

                matriz[i, j] = 0;
            }
        }

        Console.WriteLine("\nDigite as coordenadas: ");

        for (int k = 0; k < raios; k++)
        {


            var lincol = Console.ReadLine().Split();

            int linha = int.Parse(lincol[0]);
            int coluna = int.Parse(lincol[1]);

            if (matriz[linha, coluna] == 0)
            {

                matriz[linha, coluna] = 1;

            }
            else if (matriz[linha, coluna] == 1)
            {

                Console.WriteLine("2 raios caíram no mesmo local");
                return;
            }

        }

        Console.Write("Nenhum raio caiu no mesmo lugar");

    }
}
