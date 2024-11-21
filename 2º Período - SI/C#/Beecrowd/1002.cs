using System;

class Program
{

    static void Main()
    {

        double raio;
        
        raio = double.Parse(Console.ReadLine());

        Console.WriteLine($"A={(3.14159 * (raio * raio)):F4}");

    }
}
