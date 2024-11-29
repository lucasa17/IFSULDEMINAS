using System;


class tipoBanda
{

    public string nome;
    public string genero;
    public int integrantes;
    public int ranking;

}

class aulaStu
{

    static void Main()
    {

        Console.WriteLine("Sistema de cadastro de bandas");

        tipoBanda banda1 = new tipoBanda();

        Console.WriteLine("Dados da banda:");
        
        Console.Write("Nome:");
        banda1.nome = Console.ReadLine();

        Console.Write("Genero:");
        banda1.genero = Console.ReadLine(); 

        Console.Write("integrantes:");
        banda1.integrantes = int.Parse(Console.ReadLine());

        Console.Write("Ranking:");
        banda1.ranking = int.Parse(Console.ReadLine());

        Console.WriteLine("\nNome: " + banda1.nome);
        Console.WriteLine("Genero: " + banda1.genero);
        Console.WriteLine("Integrantes: " + banda1.integrantes);
        Console.WriteLine("Ranking: " + banda1.ranking);
    }

}
