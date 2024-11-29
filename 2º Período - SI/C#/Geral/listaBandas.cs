using System;


class tipoBanda
{

    public string nome;
    public string genero;
    public int integrantes;
    public int ranking;

}

class aulaStuct
{

    static void addBandas(List<tipoBanda> listadeBandas)
    {

        tipoBanda novaBanda = new tipoBanda();

        Console.WriteLine("Dados da banda:");

        Console.Write("Nome:");
        novaBanda.nome = Console.ReadLine();

        Console.Write("Genero:");
        novaBanda.genero = Console.ReadLine();

        Console.Write("integrantes:");
        novaBanda.integrantes = int.Parse(Console.ReadLine());

        Console.Write("Ranking:");
        novaBanda.ranking = int.Parse(Console.ReadLine());

        listadeBandas.Add(novaBanda);
        Console.WriteLine("Dados adicionados com sucesso!");

    }

    static void showBandas(List<tipoBanda> listadeBandas)
    {

        Console.WriteLine("Bandas cadastradas: ");

        for (int i = 0; i < listadeBandas.Count; i++)
        {

            Console.WriteLine("Banda " + (i + 1));

            Console.WriteLine("Nome: " + listadeBandas[i].nome);
            Console.WriteLine("Genero: " + listadeBandas[i].genero);
            Console.WriteLine("Integrantes: " + listadeBandas[i].integrantes);
            Console.WriteLine("Ranking: " + listadeBandas[i].ranking);

            Console.WriteLine("\n\n");
        }

    }

    static void searchBandasNome(List<tipoBanda> listadeBandas, string nome)
    {
        int cont = 0;

        for (int i = 0; i < listadeBandas.Count; i++)
        {

            if (listadeBandas[i].nome.ToUpper().Equals(nome.ToUpper()))
            {

                Console.WriteLine("Banda " + (i + 1));

                Console.WriteLine("Nome: " + listadeBandas[i].nome);
                Console.WriteLine("Genero: " + listadeBandas[i].genero);
                Console.WriteLine("Integrantes: " + listadeBandas[i].integrantes);
                Console.WriteLine("Ranking: " + listadeBandas[i].ranking);

                Console.WriteLine("\n\n");

                cont++;
            }

           
        }

        if(cont == 0)
        {

            Console.WriteLine("Banda não encontrada");

        }

    }

    static void searchBandasGenero(List<tipoBanda> listadeBandas, string nome)
    {
        int cont = 0;

        for (int i = 0; i < listadeBandas.Count; i++)
        {

            if (listadeBandas[i].genero.ToUpper().Equals(nome.ToUpper()))
            {

                Console.WriteLine("Banda " + (i + 1));

                Console.WriteLine("Nome: " + listadeBandas[i].nome);
                Console.WriteLine("Genero: " + listadeBandas[i].genero);
                Console.WriteLine("Integrantes: " + listadeBandas[i].integrantes);
                Console.WriteLine("Ranking: " + listadeBandas[i].ranking);

                Console.WriteLine("\n\n");

                cont++;
            }


        }

        if (cont == 0)
        {

            Console.WriteLine("Nenhuma banda encontrada");

        }

    }

    static int menu()
    {

        Console.WriteLine("------------------Menu------------------");
        Console.WriteLine("1 - Inserir");
        Console.WriteLine("2 - Mostrar");
        Console.WriteLine("3 - Buscar por nome");
        Console.WriteLine("4 - Buscar por genero");
        Console.WriteLine("0 - Sair");
        int op = int.Parse(Console.ReadLine());

        return op;
    }

    static void Main()
    {

        List<tipoBanda> listadeBandas = new List<tipoBanda>();

        int op;
        do
        {

            op = menu();

            switch (op)
            {

                case 1:

                    addBandas(listadeBandas);

                break;

                case 2:

                    showBandas(listadeBandas);

                break;

                case 3:

                    Console.Write("Digite o nome da banda: ");
                    string nome = Console.ReadLine();

                    searchBandasNome(listadeBandas, nome);

                break;


                case 4:

                    Console.Write("Digite o genero da banda: ");
                    string genero = Console.ReadLine();

                    searchBandasGenero(listadeBandas, genero);

                    break;

                case 0:

                    Console.WriteLine("Saindo.....");
                
                break;
            }


            Console.WriteLine("\nPressione qualquer tecla para constinuar...");
            Console.ReadKey();

            Console.Clear();

        } while (op != 0);

    }

}
