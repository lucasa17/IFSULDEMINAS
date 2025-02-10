using System;
using System.Collections.Generic;
using System.IO;

class Data
{
    public int mes;
    public int ano;
}

class Gado
{
    public int codigo;
    public double leite; 
    public double alim; 
    public Data nasc = new Data();
    public char abate;
}

class Program
{
    static void Main()
    {
        List<Gado> gadoList = new List<Gado>();
        int op;

        do
        {
            op = Menu();
            switch (op)
            {
                case 1:
                    LerDados(gadoList);
                    break;
                case 2:
                    PreencherAbate(gadoList);
                    break;
                case 3:
                    Console.WriteLine($"Total de leite produzido por semana: {TotalLeite(gadoList)} litros");
                    break;
                case 4:
                    Console.WriteLine($"Total de alimento consumido por semana: {TotalAlimento(gadoList)} quilos");
                    break;
                case 5:
                    ListarAbate(gadoList);
                    break;
                case 6:
                    SalvarDados(gadoList, "dadosGado.txt");
                    break;
                case 7:
                    CarregarDados(gadoList, "dadosGado.txt");
                    break;
                case 0:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

        } while (op != 0);
    }

    static int Menu()
    {
        Console.WriteLine("---------- Menu ----------");
        Console.WriteLine("1 - Ler dados do gado");
        Console.WriteLine("2 - Preencher campo de abate");
        Console.WriteLine("3 - Total de leite produzido por semana");
        Console.WriteLine("4 - Total de alimento consumido por semana");
        Console.WriteLine("5 - Listar animais que devem ir para o abate");
        Console.WriteLine("6 - Salvar dados em arquivo");
        Console.WriteLine("7 - Carregar dados de arquivo");
        Console.WriteLine("0 - Sair");
        Console.Write("Escolha uma opção: ");
        return int.Parse(Console.ReadLine());
    }

    static void LerDados(List<Gado> gadoList)
    {
        Console.Write("Digite o número de cabeças de gado: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Gado gado = new Gado();

            Console.Write($"Código do gado {i + 1}: ");
            gado.codigo = int.Parse(Console.ReadLine());

            Console.Write($"Leite produzido por semana (em litros) do gado {i + 1}: ");
            gado.leite = double.Parse(Console.ReadLine());

            Console.Write($"Alimento ingerido por semana (em quilos) do gado {i + 1}: ");
            gado.alim = double.Parse(Console.ReadLine());

            Console.Write($"Data de nascimento do gado {i + 1} (mês e ano): ");
            Console.Write("Mês:");
            gado.nasc.mes = int.Parse(Console.ReadLine());
            Console.Write("Ano:");
            gado.nasc.ano = int.Parse(Console.ReadLine());

            gado.abate = 'N'; 

            gadoList.Add(gado);
        }
    }

    static void PreencherAbate(List<Gado> gadoList)
    {
        foreach (var gado in gadoList)
        {
            int idade = DateTime.Now.Year - gado.nasc.ano;
            if (idade > 5 || gado.leite < 40)
            {
                gado.abate = 'S';
            }
        }
    }

    static double TotalLeite(List<Gado> gadoList)
    {
        double total = 0;
        foreach (var gado in gadoList)
        {
            total += gado.leite;
        }
        return total;
    }

    static double TotalAlimento(List<Gado> gadoList)
    {
        double total = 0;
        foreach (var gado in gadoList)
        {
            total += gado.alim;
        }
        return total;
    }

    static void ListarAbate(List<Gado> gadoList)
    {
        Console.WriteLine("Animais que devem ir para o abate:");
        foreach (var gado in gadoList)
        {
            if (gado.abate == 'S')
            {
                Console.WriteLine($"Código: {gado.codigo}, Leite: {gado.leite} litros, Alimento: {gado.alim} quilos, Nascimento: {gado.nasc.mes}/{gado.nasc.ano}");
            }
        }
    }

    static void SalvarDados(List<Gado> gadoList, string nomeArquivo)
    {
        using (StreamWriter writer = new StreamWriter(nomeArquivo))
        {
            foreach (var gado in gadoList)
            {
                writer.WriteLine($"{gado.codigo},{gado.leite},{gado.alim},{gado.nasc.mes},{gado.nasc.ano},{gado.abate}");
            }
        }
        Console.WriteLine("Dados salvos com sucesso!");
    }

    static void CarregarDados(List<Gado> gadoList, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(',');
                Gado gado = new Gado
                {
                    codigo = int.Parse(campos[0]),
                    leite = double.Parse(campos[1]),
                    alim = double.Parse(campos[2]),
                    nasc = new Data { mes = int.Parse(campos[3]), ano = int.Parse(campos[4]) },
                    abate = char.Parse(campos[5])
                };
                gadoList.Add(gado);
            }
            Console.WriteLine("Dados carregados com sucesso!");
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado.");
        }
    }
}
