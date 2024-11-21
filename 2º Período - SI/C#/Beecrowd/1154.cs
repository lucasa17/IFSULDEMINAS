using System;

class Program
{

    static void Main()
    {
        
        float idade = 0, soma = 0, cont = 0, c = 1;
        

        while(c != 0){
        
            idade = float.Parse(Console.ReadLine());

            if(idade >= 0){
                
                soma = idade + soma; 
            
                cont++;

            }
            else{
                
                c = 0;
            }
        
        }
        
        Console.WriteLine($"{soma / cont:F2}");

    }
}
