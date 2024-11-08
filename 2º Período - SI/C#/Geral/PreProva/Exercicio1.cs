using System;
using System.Runtime.Serialization;
using Arrays;
using Biblioteca_Matriz;

/*1. Análise de Ocorrências de Crimes em uma Região
Você foi contratado pela empresa Segurança Inteligente para analisar a
distribuição de ocorrências de crimes em diferentes regiões de uma cidade. A
cidade foi dividida em uma grade de bairros, e para cada bairro foi registrada
a quantidade de crimes cometidos em um período específico. Quanto maior o
valor, maior a quantidade de crimes naquela região.
Você tem uma matriz que representa a quantidade de crimes em cada região
da cidade. Seu objetivo é analisar essa matriz para encontrar as regiões com
maior número de ocorrências de crimes e também identificar os bairros com a
menor quantidade de crimes.
Preenchimento da Matriz: A matriz tem o formato de uma tabela, onde cada
célula representa um bairro da cidade e o valor nela contido representa o
número de crimes ocorridos naquele bairro. O tamanho da matriz é 5x5,
representando 5 regiões da cidade, e os valores são números aleatórios entre
0 e 50 (inclusive).

Análise de Ocorrências:
a) Armazene o total de ocorrências de cada região em um vetor com posição
correspondente
b) Apresente o total de ocorrências de cada região
c) Encontre a região onde ocorreram mais crimes.
d) Encontre a região que ocorreram menos crimes.*/

class atividade0711
{

    static void gera50(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        Random random = new Random();

        for (int i = 0; i < linhas; i++)

            for (int j = 0; j < cols; j++)

                matriz[i, j] = random.Next(0, 51);

    }
    static void Main()
    {

        int[,] matriz = new int[5,5];

        gera50(matriz);

        Biblioteca_Matriz.Matriz.mostra(matriz);

        int maior = 0, menor = 2000, regiaoMaior = 0, regiaoMenor = 0;


        for (int i = 0; i < 5; i++){

            int soma = 0;

                   Console.WriteLine("\nRegião "+i+":");

                for (int j = 0; j < 5; j++)
                {

                Console.Write(matriz[i,j]+" ");

                soma = soma + matriz[i,j];


                }

                if (soma >= maior)
                {
                    maior = soma;

                    regiaoMaior = i;

                }
                if (soma <= menor)
                {

                    menor = soma;

                    regiaoMenor = i;

                }

            Console.WriteLine("Soma: "+soma);   

        }


        Console.WriteLine("\nRegião onde ocorreram mais crimes: **" + maior + "** na Região " + regiaoMaior);
        Console.WriteLine("Região onde ocorreram menos crimes: **" + menor + "** na Região " + regiaoMenor);



    }
}
