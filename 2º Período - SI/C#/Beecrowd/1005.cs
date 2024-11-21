using System;

class Program
{

    static void Main()
    {

        float A, B;
        
        A = float.Parse(Console.ReadLine());

        B = float.Parse(Console.ReadLine());

        Console.WriteLine($"MEDIA = {((A * 3.5) + (B * 7.5))/11:F5}");

    }
}
