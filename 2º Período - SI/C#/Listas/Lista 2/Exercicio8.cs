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
    			goto volta;
    
    		}
    		

		int[,] matriz = new int[501, 501];


        for(int i = 0; i < 501; i++){
            
            for(int j = 0; j < 501; j++){
                
                matriz[i,j] = 0;
            }
        }
        
        for(int k = 0; k < raios; k++){
            
            Console.WriteLine("\nDigite as coordenadas: ");
            Console.Write("Linha:");
            int linha = int.Parse(Console.ReadLine());
            
            Console.Write("Coluna:");
            int coluna = int.Parse(Console.ReadLine());
            
                if(matriz[linha,coluna] == 0){
                    
                    matriz[linha,coluna] = 1;
                    
                }
                else if(matriz[linha,coluna] == 1){
                    
                    Console.WriteLine("Um raio caiu no mesmo local duas vezes.");
                    return;
                }
        }      
	}
}
