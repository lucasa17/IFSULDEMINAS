/*Em um arquipélago no meio do Oceano Pacífico a economia é regida pela pesca, pois o peixe é o principal alimento disponível.
Ultimamente, a população desse arquipélago tem aumentado drasticamente, o que levou a um grande aumento da pesca, e,
consequentemente, a problemas.
Neste arquipélago, cada pescador vai diariamente ao alto mar com a intenção de conseguir trazer o maior número de peixes
para o seu vilarejo. Com a expansão da pesca, os pescadores estão começando a jogar suas redes de pesca por cima das de
outros pescadores. Com isso, os pescadores perdem, pois apenas o primeiro pescador pega os peixes da intersecção entre as
redes.
A Associação dos Pescadores da ilha decidiu fazer um levantamento para descobrir quanto do mar está de fato sendo
aproveitado, ou seja, qual a área do mar que está coberta por pelo menos uma rede de pesca.
Como há muitas intersecções entre as redes de pesca, é muito difícil para a associação calcular a área total da região coberta
pelas redes. Por este motivo, eles pediram para que você escrevesse um programa para resolver este problema.
Como é muito difícil navegar pelo mar, os pescadores sempre jogam as redes de forma que as regiões cobertas por cada rede
são sempre retângulos com lados paralelos aos eixos, se imaginarmos o mar como um plano cartesiano.
Entrada: A primeira linha da entrada possui um inteiro N indicando o número de redes que foram lançadas. As
próximas N linhas descrevem as regiões cobertas pelas redes: cada uma contém quatro inteiros Xi e Xf , Yi e Yf. A região
coberta pela rede em questão contém todo ponto (X, Y) tal que Xi ≤ X ≤ Xf e Yi ≤ Y ≤ Yf
Saída: A saída deve conter apenas uma linha contendo a área da região do mar realmente aproveitada pelos pescadores,
ou seja, a área total da região do mar coberta por pelo menos uma rede de pesca.*/

using System;
using Matrizes;


class Exercicio9
{

    static void contadorRede(int[,] matriz){
        
        
        int linha = matriz.GetLength(0);
        int coluna = matriz.GetLength(1);

        int cont = 0;
        
        for (int i = 0; i < linha; i++){

            for (int j = 0; j < coluna; j++)
            {

                if(matriz[i, j] > 0){
                    
                    cont++;
                    
                }

            }
        }
        
    Console.WriteLine(cont);
    }
	
	static void Main()
	{
	    
        int redes = int.Parse(Console.ReadLine());
        
        int[,] matriz = new int[10,10];
        
            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);

            for (int i = 0; i < linha; i++)
            {

                for (int j = 0; j < coluna; j++)
                {

                    matriz[i, j] = 0;

                }

            }
        
        for(int k = 0; k < redes; k++){
            
            var xy = Console.ReadLine().Split();
            
            int xi = int.Parse(xy[0]);
            int xf = int.Parse(xy[1]);
            int yi = int.Parse(xy[2]);
            int yf = int.Parse(xy[3]);
            
                for (int l = xi; l <= xf; l++){

                    for (int m = yi; m <= yf; m++){
    
                        matriz[l,m] = matriz[l,m] + 1;
                        
                        //Console.Write("["+m+"]["+l+"] = "+matriz[m,l]);
                    }

                }
        }
        
        contadorRede(matriz);

        
    
	}
}
