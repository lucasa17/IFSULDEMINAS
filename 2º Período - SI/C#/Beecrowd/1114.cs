using System;

class Program
{

    static void Main()
    {
        
        int x, c = 0;
        

        while(c != 1){
            
            x = int.Parse(Console.ReadLine());

            if(x == 2002){
                
                Console.WriteLine("Acesso Permitido");
                
                c = 1;
            }
            else{
                
                Console.WriteLine("Senha Invalida");
                
            }
            
            
        }

    }
}
