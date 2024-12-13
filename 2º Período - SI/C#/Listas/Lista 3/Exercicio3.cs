using System;
using System.IO;

class Energia
{

    public string eletrodomestico;
    public float potencia;
    public float tempo;

}

class Exercicio3
{

    static void addEletro(List<Energia> gastoEnergia)
    {

        Energia eletro = new Energia();

        Console.WriteLine("\nDados do eletrodoméstico:");

        Console.Write("Eletrodoméstico:");
        eletro.eletrodomestico = Console.ReadLine();

        Console.Write("Potência:");
        eletro.potencia = float.Parse(Console.ReadLine());

        Console.Write("Tempo ativo(horas por dia):");
        eletro.tempo = float.Parse(Console.ReadLine());


        gastoEnergia.Add(eletro);
        Console.WriteLine("Dados adicionados com sucesso!");



    }

    static void showEletro(List<Energia> gastoEnergia)
    {

        Console.WriteLine("\nEletrodoméstico cadastrados: ");

        for (int i = 0; i < gastoEnergia.Count; i++)
        {

            Console.WriteLine("Eltrodoméstico " + (i + 1));

            Console.WriteLine("Eletrodomético: " + gastoEnergia[i].eletrodomestico);
            Console.WriteLine("Potência: " + gastoEnergia[i].potencia);
            Console.WriteLine("Tempo ativo(horas por dia): " + gastoEnergia[i].tempo);

            Console.WriteLine("\n");
        }

    }

    static void searchEletroNome(List<Energia> gastoEnergia, string nome)
    {
        int cont = 0;

        for (int i = 0; i < gastoEnergia.Count; i++)
        {

            if (gastoEnergia[i].eletrodomestico.ToUpper().Equals(nome.ToUpper()))
            {

                Console.WriteLine("Eletrodoméstico " + (i + 1));


                Console.WriteLine("Eletrodomético: " + gastoEnergia[i].eletrodomestico);
                Console.WriteLine("Potência: " + gastoEnergia[i].potencia);
                Console.WriteLine("Tempo ativo(horas por dia): " + gastoEnergia[i].tempo);

                Console.WriteLine("\n");

                cont++;
            }


        }

        if (cont == 0)
        {

            Console.WriteLine("Eletrodomético não encontrado");

        }

    }

    static void searchEletroGasto(List<Energia> gastoEnergia, float gasto)
    {

        int cont = 0;

        Console.WriteLine("Eletrodoméstico cadastrados: ");


        for (int i = 0; i < gastoEnergia.Count; i++)
        {

            float gastoAux = 0;

            gastoAux = gastoEnergia[i].potencia * gastoEnergia[i].tempo;

            if(gastoAux > gasto)
            {

                Console.WriteLine("Eltrodoméstico " + (i + 1));

                Console.WriteLine("Eletrodomético: " + gastoEnergia[i].eletrodomestico);
                Console.WriteLine("Potência: " + gastoEnergia[i].potencia);
                Console.WriteLine("Tempo ativo(horas por dia): " + gastoEnergia[i].tempo);

                Console.WriteLine("\n");

                cont++;

            }

        }

        if (cont == 0)
        {

            Console.WriteLine("Nenhum eletrodoméstico encontrado");

        }

    }

    static void searchEletroGastoDM(List<Energia> gastoEnergia)
    {

        int cont = 0;

        float gasto = 0;


        for (int i = 0; i < gastoEnergia.Count; i++)
        {

            gasto = gastoEnergia[i].potencia * gastoEnergia[i].tempo;


        }

        Console.WriteLine("Gasto total diário "+ gasto/24 +"kW/h");
        Console.WriteLine("Gasto total mensal " + (gasto*30)/24 + "kW/h");

        Console.WriteLine("\nUsando o preço de R$0,85 kW/h temos:");
        Console.WriteLine("Gasto total diário R$" + (gasto / 24)*0.85);
        Console.WriteLine("Gasto total mensal R$" + ((gasto * 30) / 24)*0.85);


    }

    static void salvarDados(List<Energia> gastoEnergia, string nomeArquivo)
    {
        StreamWriter writer = new StreamWriter(nomeArquivo);

        foreach (Energia eletro in gastoEnergia)
        {
            writer.WriteLine($"{eletro.eletrodomestico},{eletro.potencia},{eletro.tempo}");
        }

        Console.WriteLine("Dados salvos com sucesso!");
        writer.Dispose();
    }



    static void carregarDados(List<Energia> gastoEnergia, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);

            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(',');

                Energia eletro = new Energia();

                eletro.eletrodomestico = campos[0];
                eletro.potencia = float.Parse(campos[1]);
                eletro.tempo = float.Parse(campos[2]);
                gastoEnergia.Add(eletro);
            }

            Console.WriteLine("Dados carregados com sucesso!");
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado :(");
        }
    }

    static void adicionaArquivo(List<Energia> gastoEnergia, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(',');

                Energia eletro = new Energia();

                eletro.eletrodomestico = campos[0];
                eletro.potencia = float.Parse(campos[1]);
                eletro.tempo = float.Parse(campos[2]);
                gastoEnergia.Add(eletro);

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

        Console.WriteLine("------------------Menu------------------");
        Console.WriteLine("1 - Cadastrar eletrodoméstico");
        Console.WriteLine("2 - Mostrar eletrodoméstico");
        Console.WriteLine("3 - Buscar eletrodoméstico por nome");
        Console.WriteLine("4 - Buscar eletrodomésticos por maior gasto diário");
        Console.WriteLine("5 - Valor gasto diariamente e mensalmente");
        Console.WriteLine("6 - Carregue um arquivo");
        Console.WriteLine("0 - Sair");


        int op = int.Parse(Console.ReadLine());

        return op;
    }

    static void Main()
    {


        List<Energia> gastoEnergia = new List<Energia>();

        int op;

        carregarDados(gastoEnergia, "dadosEnergia.txt");

        do
        {

            op = menu();

            switch (op)
            {

                case 1:

                    addEletro(gastoEnergia);

                    break;

                case 2:

                    showEletro(gastoEnergia);

                    break;

                case 3:

                    Console.Write("Digite o nome do eletrodoméstico: ");
                    string nome = Console.ReadLine();

                    searchEletroNome(gastoEnergia, nome);

                    break;

                case 4:

                    Console.Write("Digite o gasto diário que deseja: ");
                    float gasto = float.Parse(Console.ReadLine());

                    searchEletroGasto(gastoEnergia, gasto);

                    break;

                case 5:

                    searchEletroGastoDM(gastoEnergia);

                    break;

                case 6:

                    Console.Write("Digite o nome do arquivo (inclua .txt): ");
                    string nomeArq = Console.ReadLine();

                    adicionaArquivo(gastoEnergia, nomeArq);

                    break;

                case 0:

                    salvarDados(gastoEnergia, "dadosEnergia.txt");
                    Console.WriteLine("Saindo.....");

                    break;

                default:

                    Console.WriteLine("Essa opção não existe");

                    break;

            }

            Console.WriteLine("\nPressione qualquer tecla para constinuar...");
            Console.ReadKey();

            Console.Clear();

        } while (op != 0);

    }
}
