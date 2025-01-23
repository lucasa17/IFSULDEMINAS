using System;
using System.IO;
using System.Collections.Generic;
using static System.Math;

class TipoViagem
{
    public string modeloVeiculo;
    public string placaVeiculo;
    public string destino;
    public double kmRodados;
    public double consumoMedio;
}

class Program
{
    static void addViagem(List<TipoViagem> listaDeViagens)
    {
        TipoViagem novaViagem = new TipoViagem();

        Console.WriteLine("*** Dados para Viagem ***");

        Console.Write("Modelo do Veículo: ");
        novaViagem.modeloVeiculo = Console.ReadLine();

        Console.Write("Placa do Veículo: ");
        novaViagem.placaVeiculo = Console.ReadLine();

        Console.Write("Destino: ");
        novaViagem.destino = Console.ReadLine();

        Console.Write("Quilômetros Rodados: ");
        novaViagem.kmRodados = double.Parse(Console.ReadLine());

        Console.Write("Consumo Médio (km/L): ");
        novaViagem.consumoMedio = double.Parse(Console.ReadLine());

        listaDeViagens.Add(novaViagem);
        Console.WriteLine("Viagem cadastrada com sucesso!");
    }
    
    static void mostraViagem(List<TipoViagem> listaDeViagem)
    {

        Console.WriteLine("Viagens\n");

        for (int i = 0; i < listaDeViagem.Count; i++)
        {

            Console.WriteLine("\nViagem " + (i+1));

            Console.WriteLine("Modelo do Veículo: " + listaDeViagem[i].modeloVeiculo);

            Console.WriteLine("Placa do Veículo: " + listaDeViagem[i].placaVeiculo);

            Console.WriteLine("Destino: " + listaDeViagem[i].destino);

            Console.WriteLine("Quilômetros Rodados: " + listaDeViagem[i].kmRodados);

            Console.WriteLine("Consumo Médio (km/L): " + listaDeViagem[i].consumoMedio);

        }
    }

    static void mostraViagemPlaca(List<TipoViagem> listaDeViagem, string placa)
    {

        Console.WriteLine("\nViagens\n");

        for (int i = 0; i < listaDeViagem.Count; i++)
        {

            if (listaDeViagem[i].placaVeiculo.ToUpper().Equals(placa.ToUpper()))
            {

                Console.WriteLine("\nViagem " + (i + 1));

                Console.WriteLine("Modelo do Veículo: " + listaDeViagem[i].modeloVeiculo);

                Console.WriteLine("Placa do Veículo: " + listaDeViagem[i].placaVeiculo);

                Console.WriteLine("Destino: " + listaDeViagem[i].destino);

                Console.WriteLine("Quilômetros Rodados: " + listaDeViagem[i].kmRodados);

                Console.WriteLine("Consumo Médio (km/L): " + listaDeViagem[i].consumoMedio);

            }


        }
    }

    static void mostraViagemCombustivel(List<TipoViagem> listaDeViagem, double combustivel)
    {

        Console.WriteLine("\nViagens\n");

        for (int i = 0; i < listaDeViagem.Count; i++)
        {

            double litros = listaDeViagem[i].kmRodados / listaDeViagem[i].consumoMedio;

            if (litros >= combustivel)
            {

                Console.WriteLine("\nViagem " + (i + 1));

                Console.WriteLine("Modelo do Veículo: " + listaDeViagem[i].modeloVeiculo);

                Console.WriteLine("Placa do Veículo: " + listaDeViagem[i].placaVeiculo);

                Console.WriteLine("Destino: " + listaDeViagem[i].destino);

                Console.WriteLine("Quilômetros Rodados: " + listaDeViagem[i].kmRodados);

                Console.WriteLine("Consumo Médio (km/L): " + listaDeViagem[i].consumoMedio);

            }


        }
    }

    static void mostraViagemRelatorio(List<TipoViagem> listaDeViagem, double preco)
    {

        double litrosTotal = 0, valorTotal = 0;

        Console.WriteLine("Preço do combustível: " + preco);

        Console.WriteLine("\nViagens\n");

        for (int i = 0; i < listaDeViagem.Count; i++)
        {

            double litros = listaDeViagem[i].kmRodados / listaDeViagem[i].consumoMedio;
            double valor = litros * preco;

                Console.WriteLine("\nViagem " + (i + 1));

                Console.WriteLine("Modelo do Veículo: " + listaDeViagem[i].modeloVeiculo);

                Console.WriteLine("Placa do Veículo: " + listaDeViagem[i].placaVeiculo);

                Console.WriteLine("Destino: " + listaDeViagem[i].destino);

                Console.WriteLine("Quilômetros Rodados: " + listaDeViagem[i].kmRodados);

                Console.WriteLine("Consumo Médio (km/L): " + listaDeViagem[i].consumoMedio);

                Console.WriteLine("Litros de combustível usados: " + litros);

                Console.WriteLine("Valor gasto em combustível na viagem: R$" + Round(valor,2));

            litrosTotal = litrosTotal + litros;
            valorTotal = valorTotal + valor;

        }

        Console.WriteLine("\nTotal de litros de combustível usados: "+litrosTotal);
        Console.WriteLine("Total de dinheiro gasto R$: " + valorTotal);

    }


    static void salvarDados(List<TipoViagem> listaDeViagens, string nomeArquivo)
    {
        StreamWriter writer = new StreamWriter(nomeArquivo);

        foreach (TipoViagem viagem in listaDeViagens)
        {
            writer.WriteLine($"{viagem.modeloVeiculo},{viagem.placaVeiculo},{viagem.kmRodados},{viagem.consumoMedio},{viagem.destino}");
        }

        Console.WriteLine("Dados salvos com sucesso!");
        writer.Dispose();
    }

    static void carregarDados(List<TipoViagem> listaDeViagens, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(',');
                TipoViagem viagem = new TipoViagem();
                viagem.modeloVeiculo = campos[0];
                viagem.placaVeiculo = campos[1];
                viagem.kmRodados = double.Parse(campos[2]);
                viagem.consumoMedio = double.Parse(campos[3]);
                viagem.destino = campos[4];
                listaDeViagens.Add(viagem);
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
        Console.WriteLine("*** Sistema de Controle de Viagens ***");
        Console.WriteLine("1 - Inserir Viagem");
        Console.WriteLine("2 - Mostrar Viagens");
        Console.WriteLine("3 - Mostrar Viagens por placa");
        Console.WriteLine("4 - Mostrar Viagens que gastaram mais combustível");
        Console.WriteLine("5 - Gerar relatório");
        Console.WriteLine("0 - Sair");

        int op = int.Parse(Console.ReadLine());

        return op;
    }

    static void Main()
    {
        List<TipoViagem> listaDeViagens = new List<TipoViagem>();
        int op;
        carregarDados(listaDeViagens, "viagens.txt");
        do
        {
            op = menu();
            switch (op)
            {
                case 1:

                    addViagem(listaDeViagens);

                    break;

                case 2:

                    mostraViagem(listaDeViagens);

                    break;

                case 3:
                    Console.Write("Digite a placa do veículo: ");
                    string placa = Console.ReadLine();

                    mostraViagemPlaca(listaDeViagens, placa);

                    break;

                case 4:
                    Console.Write("Digite a quatia de combustível desejada(em Litros): ");

                    double combustivel = double.Parse(Console.ReadLine());

                    mostraViagemCombustivel(listaDeViagens, combustivel);

                    break;


                case 5:
                    Console.Write("Digite o valor do combustível: ");

                    double preco = double.Parse(Console.ReadLine());

                    mostraViagemRelatorio(listaDeViagens, preco);

                    break;

                case 0:
                    Console.WriteLine("Saindo...");

                    salvarDados(listaDeViagens, "viagens.txt");

                    break;
            }
            Console.ReadKey();
            Console.Clear();
        } while (op != 0);
    }
}
