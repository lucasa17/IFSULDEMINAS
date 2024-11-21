using System;


class Exercicio8
{

	
	static void Main()
	{

        int[] vetor = new int[10];

                for (int i = 0; i < 10; i++)
                {
                        vetor[i] = int.Parse(Console.ReadLine());
    
                }
                
                    for (int j = 0; j < 10; j++)
                    {
                        
                        if(vetor[j] <= 0){
                            
                        Console.WriteLine("X["+j+"] = 1");
                        }
                        else{
                            
                        Console.WriteLine("X["+j+"] = "+vetor[j]);
                        
                        }
                        
                        
                    }
                    
                }
                
               
        }
