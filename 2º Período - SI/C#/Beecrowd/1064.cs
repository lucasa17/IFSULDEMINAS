using System;

class Program
{

    static void Main()
    {

        float num, cont = 0, soma = 0;
        
        for(int a = 1; a <= 6; a++){
            
            num = 0;
            
            num = float.Parse(Console.ReadLine()); 
            
            if(num > 0){
                
                soma = num + soma;
                cont++;
            }

        }
            
            Console.WriteLine($"{cont} valores positivos");
            Console.WriteLine($"{(soma/cont):F1}");

        }
    
}
