using System;

class exercicio3
{

    static void Main()
    {

        Console.WriteLine("Exercicio 3");

        Console.WriteLine("Entre com uma palavra: ");
        string palavra = Console.ReadLine();

        Console.WriteLine(palavra+"\n");

        Console.WriteLine("Posição para acessar: ");
        int pos = int.Parse(Console.ReadLine());

        Console.Write("Caracter: ");
        Console.WriteLine(palavra[pos]);

        Console.Write("ASCII: ");
        Console.WriteLine((int)palavra[pos]);

        char[] vetorChar = palavra.ToCharArray();
        Console.WriteLine((int)palavra[pos]);

        Console.ReadKey();

    }
}