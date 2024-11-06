/*Você deve implementar um programa em C# que ajude o mago a calcular a força total das tropas de cada
região. Para isso, crie uma matriz de tamanho R x C, onde R representa o número de regiões (linhas) e C o número
de cidades (colunas) em cada região.
Cada elemento da matriz conterá o número total de tropas (guerreiros, arqueiros e magos) naquela cidade. Seu
programa deve fazer o seguinte:
1. Preencher a matriz com números aleatórios (representando o número de tropas em cada cidade), variando
de 0 a 100.
2. Exibir a matriz gerada (a quantidade de tropas em cada cidade).
3. Para cada linha (região), calcular e exibir a soma total das tropas da região.*/

using System;
using Matrizes;


class Exercicio10
{

    static void contaTropas(int[,] matriz){
        
        int linha = matriz.GetLength(0);
        int coluna = matriz.GetLength(1);

        int ir = 0;

        Console.Write("\n\n");
            for (int i = 0; i < linha; i++){
             
            int conttropa = 0;
            ir++;
                
                Console.Write("Região "+ir+": ");
                
                for (int j = 0; j < coluna; j++)
                {
                    
                    conttropa = conttropa + matriz[i,j];
                    
                }
            
            Console.Write(conttropa+"\n");
            }
        
    }
    
	static void Main()
	{
	    Console.WriteLine("Matriz das Tropas (Quantidade de Tropas por Cidade):");
	    
	    Console.Write("Regiões: ");
        int regioes = int.Parse(Console.ReadLine());
        
        Console.Write("Cidades: ");
        int cidades = int.Parse(Console.ReadLine());
        
        int[,] matriz = new int[regioes,cidades];
        
        bibliotecaMatriz.randomMatriz100(matriz);
        

            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);

            int ir = 0;

                for (int i = 0; i < linha; i++){
                  
                ir++;
                    
                Console.Write("\nRegião "+ir+": ");
                    
                    for (int j = 0; j < coluna; j++)
                    {
        
                        Console.Write(matriz[i,j]+" ");
                        
                    }
    
                }
        
        contaTropas(matriz);
    
	}
}
