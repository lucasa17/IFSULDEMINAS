using System;

class Program
{

    static void Main()
    {
        
        int x;
        
        x = int.Parse(Console.ReadLine());

        for(int a = 1; a <= x; a++){
            
            if(a %2 != 0){
                
                Console.WriteLine($"{a}");
                
            }
        }

    }
}
