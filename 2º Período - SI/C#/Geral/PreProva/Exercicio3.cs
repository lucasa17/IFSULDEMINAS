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
        
        Console.WriteLine("Posicao em minusculo");
        vetorChar[pos] = (char)(vetorChar[pos] + 32);
        Console.WriteLine($"{vetorChar[pos]}");
        
        Console.WriteLine("Palavra modificada:");
        for(int i = 0; i < vetorChar.Length; i++)
        {
            Console.Write(vetorChar[i]);
        }


        Console.ReadKey();

    }
}
