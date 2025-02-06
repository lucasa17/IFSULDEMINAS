using System;
using System.IO;
using System.Collections.Generic;
using System.Numerics;

class TipoSalaAula
{
    public int numeroSala;
    public string localizacao;
    public string tipo;
    public double tamanho;
    public int quantidadeCadeiras;
}

class Program
{
    static void adicionarSala(List<TipoSalaAula> listaSalas)
    {
        TipoSalaAula novaSala = new TipoSalaAula();
        Console.WriteLine("*** Cadastro de Sala ***");
        Console.Write("Número da Sala: ");
        novaSala.numeroSala = int.Parse(Console.ReadLine());
        Console.Write("Localização: ");
        novaSala.localizacao = Console.ReadLine();
        Console.Write("Tipo da Sala: ");
        novaSala.tipo = Console.ReadLine();
        Console.Write("Tamanho (m²): ");
        novaSala.tamanho = double.Parse(Console.ReadLine());
        Console.Write("Quantidade de Cadeiras: ");
        novaSala.quantidadeCadeiras = int.Parse(Console.ReadLine());
        listaSalas.Add(novaSala);
        Console.WriteLine("Sala cadastrada com sucesso!");
    }

    static void mostrarSalas(List<TipoSalaAula> listaSalas)
    {

        Console.WriteLine("Salas:\n");

        for (int i = 0; i < listaSalas.Count; i++)
        {

            Console.WriteLine("\nSala " + (i + 1));

            Console.WriteLine("Número da Sala: " + listaSalas[i].numeroSala);

            Console.Write("Tipo da Sala: " + listaSalas[i].tipo);

            Console.WriteLine("Localização: " + listaSalas[i].localizacao);

            Console.WriteLine("Tipo da Sala: " + listaSalas[i].tipo);

            Console.WriteLine("Tamanho (m²): " + listaSalas[i].tamanho);

            Console.WriteLine("Quantidade de Cadeiras: " + listaSalas[i].quantidadeCadeiras);

        }
    }

    static void mostraSalaNumero(List<TipoSalaAula> listaSalas, int numero)
    {

        for (int i = 0; i < listaSalas.Count; i++)
        {
            if (listaSalas[i].numeroSala == numero)
            {
                
                Console.WriteLine("\nSala " + (i + 1));
    
                Console.WriteLine("Número da Sala: " + listaSalas[i].numeroSala);
    
                Console.Write("Tipo da Sala: " + listaSalas[i].tipo);
    
                Console.WriteLine("Localização: " + listaSalas[i].localizacao);
    
                Console.WriteLine("Tipo da Sala: " + listaSalas[i].tipo);
    
                Console.WriteLine("Tamanho (m²): " + listaSalas[i].tamanho);
    
                Console.WriteLine("Quantidade de Cadeiras: " + listaSalas[i].quantidadeCadeiras);

            }
        }
    }
    
    static void mostraSalaTamanho(List<TipoSalaAula> listaSalas, double tamanho)
    {

        Console.WriteLine("Salas:\n");

        for (int i = 0; i < listaSalas.Count; i++)
        {
            if (listaSalas[i].tamanho >= tamanho)
            {
                
                Console.WriteLine("\nSala " + (i + 1));
    
                Console.WriteLine("Número da Sala: " + listaSalas[i].numeroSala);
    
                Console.Write("Tipo da Sala: " + listaSalas[i].tipo);
    
                Console.WriteLine("Localização: " + listaSalas[i].localizacao);
    
                Console.WriteLine("Tipo da Sala: " + listaSalas[i].tipo);
    
                Console.WriteLine("Tamanho (m²): " + listaSalas[i].tamanho);
    
                Console.WriteLine("Quantidade de Cadeiras: " + listaSalas[i].quantidadeCadeiras);

            }
        }
    }
    
    static void maiorSala(List<TipoSalaAula> listaSalas){
        
        double tamanho = listaSalas[0].tamanho;
        
        int cont = 0;
        
            for (int i = 0; i < listaSalas.Count; i++)
            {
            
                if(listaSalas[i].tamanho > tamanho){
                    
                    cont = i;
                    
                }
                
            }
        
                Console.WriteLine("\nMaior Sala em metragem é a " + cont);
    
                Console.WriteLine("Número da Sala: " + listaSalas[cont].numeroSala);
    
                Console.Write("Tipo da Sala: " + listaSalas[cont].tipo);
    
                Console.WriteLine("Localização: " + listaSalas[cont].localizacao);
    
                Console.WriteLine("Tipo da Sala: " + listaSalas[cont].tipo);
    
                Console.WriteLine("Tamanho (m²): " + listaSalas[cont].tamanho);
    
                Console.WriteLine("Quantidade de Cadeiras: " + listaSalas[cont].quantidadeCadeiras);

        
    }
    
    static void mostraSalaCadeiras(List<TipoSalaAula> listaSalas, int cadeiras)
    {

        Console.WriteLine("Salas:\n");

        for (int i = 0; i < listaSalas.Count; i++)
        {
            if (listaSalas[i].quantidadeCadeiras >= cadeiras)
            {
                
                Console.WriteLine("\nSala " + (i + 1));
    
                Console.WriteLine("Número da Sala: " + listaSalas[i].numeroSala);
    
                Console.Write("Tipo da Sala: " + listaSalas[i].tipo);
    
                Console.WriteLine("Localização: " + listaSalas[i].localizacao);
    
                Console.WriteLine("Tipo da Sala: " + listaSalas[i].tipo);
    
                Console.WriteLine("Tamanho (m²): " + listaSalas[i].tamanho);
    
                Console.WriteLine("Quantidade de Cadeiras: " + listaSalas[i].quantidadeCadeiras);

            }
        }
    }
    
    
    static void geraRelatorio(List<TipoSalaAula> listaSalas)
    {

        double tamanho = 0;

        Console.WriteLine("Relatório:\n");

        for (int i = 0; i < listaSalas.Count; i++)
        {
            
            tamanho += listaSalas[i].tamanho;


        }
        
            Console.WriteLine("Número de salas: " + (listaSalas.Count));

            Console.WriteLine("Tamanho total das salas(m²): " + tamanho);

    }
    
    
    static void salvarDados(List<TipoSalaAula> listaSalas, string nomeArquivo)
    {
        StreamWriter writer = new StreamWriter(nomeArquivo);
        foreach (TipoSalaAula sala in listaSalas)
        {
            writer.WriteLine($"{sala.numeroSala};{sala.localizacao};{sala.tipo};{sala.tamanho.ToString("N2")};{sala.quantidadeCadeiras}");
        }
        writer.Dispose();
        Console.WriteLine("Dados salvos com sucesso!");
    }

    static void carregarDados(List<TipoSalaAula> listaSalas, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(';');
                TipoSalaAula sala = new TipoSalaAula();
                sala.numeroSala = int.Parse(campos[0]);
                sala.localizacao = campos[1];
                sala.tipo = campos[2];
                sala.tamanho = double.Parse(campos[3]);
                sala.quantidadeCadeiras = int.Parse(campos[4]);
                listaSalas.Add(sala);
            }
            Console.WriteLine("Dados carregados com sucesso!");
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado :(");
        }
    }

    static int menu()
    {
        Console.WriteLine("*** Controle de Reservas de Salas ***");
        Console.WriteLine("1 - Adicionar Sala");
        Console.WriteLine("2 - Mostrar Salas");
        Console.WriteLine("3 - Buscar sala por número");
        Console.WriteLine("4 - Buscar sala por tamanho");
        Console.WriteLine("5 - Buscar maior sala");
        Console.WriteLine("6 - Buscar sala por quantidades de cadeiras");
        Console.WriteLine("7 - Gerar relatório");
        Console.WriteLine("0 - Sair");
        Console.Write("Opção: ");
        return int.Parse(Console.ReadLine());
    }

    static void Main()
    {
        List<TipoSalaAula> listaSalas = new List<TipoSalaAula>();
        int op;
        carregarDados(listaSalas, "salas.txt");
        do
        {
            op = menu();
            switch (op)
            {
                case 1:

                    adicionarSala(listaSalas);

                    break;

                case 2:

                    mostrarSalas(listaSalas);

                    break;

                case 3:

                    Console.WriteLine("Digite o número da sala: ");

                    int numero = int.Parse(Console.ReadLine());

                    mostraSalaNumero(listaSalas, numero);

                    break;

                case 4:

                    Console.WriteLine("Digite o tamanho: ");

                    double tamanho = double.Parse(Console.ReadLine());

                    mostraSalaTamanho(listaSalas, tamanho);

                    break;

                case 5:

                    maiorSala(listaSalas);

                    break;
                
                case 6:

                    Console.WriteLine("Digite a quantidade minima de cadeiras: ");

                    int cadeiras = int.Parse(Console.ReadLine());

                    mostraSalaCadeiras(listaSalas, cadeiras);

                    break;
                    
                    
                case 7:

                    geraRelatorio(listaSalas);

                    break;
                    
                case 0:

                    Console.WriteLine("Saindo...");

                    salvarDados(listaSalas, "salas.txt");

                    break;

            }
            Console.ReadKey();
            Console.Clear();
        } while (op != 0);
    }
}
