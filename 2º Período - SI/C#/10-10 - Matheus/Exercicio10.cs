/*Tentando descobrir se um dado era viciado, um dono de cassino honesto o lançou N vezes. Dados os n
resultados dos lançamentos que devem ser armazenados em um vetor, determinar o número de ocorrências
de cada face.*/

using System;
using Arrays;

class Exercicio10
{

    static void dadoVetor(int[] vetor1)
    {
        
            Random random = new Random();

            for (int i = 0; i < vetor1.Length; i++)
            {
                
                vetor1[i] = random.Next(1, 7);

            }
            
            BibliotecaArray.showArray(vetor1);
        
        int d1=0, d2=0, d3=0, d4=0, d5=0, d6=0;

        for (int i = 0; i < vetor1.Length; i++)
        {
            
            if(vetor1[i] == 1){
                
                d1++;
        
            }
            if(vetor1[i] == 2){
                
                d2++;
        
            }
            if(vetor1[i] == 3){
                
                d3++;
        
            }
            if(vetor1[i] == 4){
                
                d4++;
        
            }
            if(vetor1[i] == 5){
                
                d5++;
        
            }
            if(vetor1[i] == 6){
                
                d6++;
        
            }

        }
        
        Console.WriteLine("\n\nVezes que cada lado apareceu: ");
        Console.WriteLine("Lado 1: "+d1);
        Console.WriteLine("Lado 2: "+d2);
        Console.WriteLine("Lado 3: "+d3);
        Console.WriteLine("Lado 4: "+d4);
        Console.WriteLine("Lado 5: "+d5);
        Console.WriteLine("Lado 6: "+d6);
        
    }

    static void Main()
    {

        int[] vetor1;


        Console.Write("Digite quantos valores deseja nos vetores: ");
        int quant = int.Parse(Console.ReadLine());

        vetor1 = new int[quant];//declando vetor 

        dadoVetor(vetor1);
        

    }

}

