using System;


class Exercicio8
{

	
	static void Main()
	{

        double[,] matriz = new double[12,12];
        
        int num = int.Parse(Console.ReadLine());
        
        char esc = char.Parse(Console.ReadLine());
        
                double linha = matriz.GetLength(0);
                double coluna = matriz.GetLength(1);
    
                for (int i = 0; i < linha; i++)
                {
    
                    for (int j = 0; j < coluna; j++)
                    {
    
                        matriz[i, j] = double.Parse(Console.ReadLine());
    
                    }
    
                }

        double resp = 0;

        switch(esc){
            
            case 'S':
        
                for (int i = num; i <= num; i++)
                {
        
                    for (int j = 0; j < 12; j++)
                    {
        
                        resp = matriz[num,j] + resp;
                    }
                }
                
                Console.WriteLine($"{resp:F1}");
            break;
            
            case 'M':
        
                for (int i = num; i <= num; i++)
                {
        
                    for (int j = 0; j < 12; j++)
                    {
        
                        resp = matriz[num,j] + resp;
                    }
                }
                
                Console.WriteLine($"{resp/12:F1}");
            break;
        }
		
       
	}
}
