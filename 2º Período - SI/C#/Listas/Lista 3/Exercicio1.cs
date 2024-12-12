/*
 1. Defina uma estrutura que irá representar bandas de música. Essa estrutura deve ter o nome da
banda, que tipo de música ela toca, o número de integrantes e em que posição do ranking essa
banda está dentre as suas bandas favoritas.
a) Crie uma função que permita cadastrar bancas.
b) Crie uma função que liste todas bandas cadastradas.
c) Salve todos os dados em um arquivo e permita carregar posteriormente.
d) Seu programa deve exibir informações das bandas cuja posição no seu ranking é a que foi
solicitada pelo usuário
e) Crie uma função em que peça ao usuário um gênero de música e exiba todos dados das bandas
com este genero.
f) Crie uma função que peça o nome de uma banda ao usuário e retorne com todos os dados desta
banda.
g) Crie uma opção excluir uma banda.
h) Crie uma função para alterar os dados de uma banda [após encontrar a banda, leia novamente
todos os dados].
i) Organize tudo em uma aplicação que exibe um menu as opções de preencher as estruturas e
todas as opções das questões passadas mais a possibilidade do usuário carregar os dados já
gravados.
 */

using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;


class tipoBanda
{

    public string nome;
    public string genero;
    public int integrantes;
    public int ranking;

}

class Exercicio1{

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

        volta:

        Console.Write("Ranking:");
        novaBanda.ranking = int.Parse(Console.ReadLine());

        int cont = 0; 

        for (int i = 0; i < listadeBandas.Count; i++)
        {

            if (novaBanda.ranking == listadeBandas[i].ranking)
            {
                Console.WriteLine("\nJá existe uma banda nesse ranking\n");

                Console.WriteLine("Banda " + (i + 1));

                Console.WriteLine("Nome: " + listadeBandas[i].nome);
                Console.WriteLine("Genero: " + listadeBandas[i].genero);
                Console.WriteLine("Integrantes: " + listadeBandas[i].integrantes);
                Console.WriteLine("Ranking: " + listadeBandas[i].ranking);

                Console.WriteLine("\n");

                cont++;
            }
        }

        if(cont != 1)
        {

            listadeBandas.Add(novaBanda);
            Console.WriteLine("Dados adicionados com sucesso!");

        }
        else
        {
            Console.WriteLine("Digite outro ranking.");

            goto volta;

        }


    }

    static void showBandas(List<tipoBanda> listadeBandas)
    {

        Console.WriteLine("\nBandas cadastradas: ");

        for (int i = 0; i < listadeBandas.Count; i++)
        {

            Console.WriteLine("Banda " + (i + 1));

            Console.WriteLine("Nome: " + listadeBandas[i].nome);
            Console.WriteLine("Genero: " + listadeBandas[i].genero);
            Console.WriteLine("Integrantes: " + listadeBandas[i].integrantes);
            Console.WriteLine("Ranking: " + listadeBandas[i].ranking);

            Console.WriteLine("\n");
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

                Console.WriteLine("\n");

                cont++;
            }


        }

        if (cont == 0)
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

                Console.WriteLine("\n");

                cont++;
            }


        }

        if (cont == 0)
        {

            Console.WriteLine("Nenhuma banda encontrada");

        }

    }

    static void searchBandasRanking(List<tipoBanda> listadeBandas, int ranking)
    {
        int cont = 0;

        for (int i = 0; i < listadeBandas.Count; i++)
        {

            if (listadeBandas[i].ranking == ranking)
            {

                Console.WriteLine("Banda " + (i + 1));

                Console.WriteLine("Nome: " + listadeBandas[i].nome);
                Console.WriteLine("Genero: " + listadeBandas[i].genero);
                Console.WriteLine("Integrantes: " + listadeBandas[i].integrantes);
                Console.WriteLine("Ranking: " + listadeBandas[i].ranking);

                Console.WriteLine("\n");

                cont++;
            }


        }

        if (cont == 0)
        {

            Console.WriteLine("Nenhuma banda encontrada");

        }

    }

    static void alterBanda(List<tipoBanda> listadeBandas, string nomeAlter)
    {
        for (int i = 0; i < listadeBandas.Count; i++)
        {
            string nomeAtual = listadeBandas[i].nome.ToUpper();

            if (nomeAtual.Contains(nomeAlter.ToUpper()))
            {
                Console.WriteLine($"*** Banda {i + 1} ***");
                Console.WriteLine($"Nome:{listadeBandas[i].nome}");
                Console.WriteLine($"Gênero:{listadeBandas[i].genero}");
                Console.WriteLine($"Integrantes:{listadeBandas[i].integrantes}");
                Console.WriteLine($"Ranking:{listadeBandas[i].ranking}");
                Console.WriteLine("------------------------------");

                Console.WriteLine("Tem certeza que deseja alterar [S/N]?");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 'S' || resp == 's')
                {
                    tipoBanda novaBanda = new tipoBanda();
                    Console.WriteLine("*** Dados para alterar a Banda ***");
                    Console.Write("Nome:");
                    novaBanda.nome = Console.ReadLine();
                    Console.Write("Gênero:");
                    novaBanda.genero = Console.ReadLine();
                    Console.Write("Integrantes:");
                    novaBanda.integrantes = int.Parse(Console.ReadLine());
                    Console.Write("Ranking:");
                    novaBanda.ranking = int.Parse(Console.ReadLine());
                    
                    listadeBandas[i] = novaBanda;

                    Console.WriteLine("Banda alterada com sucesso!");
                }

                else{

                    Console.WriteLine("Operação cancelada");
                
                }

                break;
            }
        }

    }

    static void deleteBanda(List<tipoBanda> listadeBandas, string nomeDel)
    {

        for (int i = 0; i < listadeBandas.Count; i++)
        {

            if (listadeBandas[i].nome.Equals(nomeDel))
            {

                Console.WriteLine($"*** Banda {i + 1} ***");
                Console.WriteLine($"Nome:{listadeBandas[i].nome}");
                Console.WriteLine($"Gênero:{listadeBandas[i].genero}");
                Console.WriteLine($"Integrantes:{listadeBandas[i].integrantes}");
                Console.WriteLine($"Ranking:{listadeBandas[i].ranking}");
                Console.WriteLine("------------------------------");

                Console.WriteLine("Tem certeza que deseja excluir [S/N]?");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 'S' || resp == 's')
                {
                    listadeBandas.RemoveAt(i);
                    Console.WriteLine("Banda excluída com sucesso!");
                }
                else
                {
                    Console.WriteLine("Operação cancelada");
                }

                break;
            }
        }
    }

        static void salvarDados(List<tipoBanda> listadeBandas, string nomeArquivo)
        {
            StreamWriter writer = new StreamWriter(nomeArquivo);

            foreach (tipoBanda banda in listadeBandas)
            {
                writer.WriteLine($"{banda.nome},{banda.genero},{banda.integrantes},{banda.ranking}");
            }

            Console.WriteLine("Dados salvos com sucesso!");
            writer.Dispose();
        }



        static void carregarDados(List<tipoBanda> listadeBandas, string nomeArquivo)
        {
            if (File.Exists(nomeArquivo))
            {
                string[] linhas = File.ReadAllLines(nomeArquivo);
                foreach (string linha in linhas)
                {
                    string[] campos = linha.Split(',');
                    tipoBanda banda = new tipoBanda();
                    banda.nome = campos[0];
                    banda.genero = campos[1];
                    banda.integrantes = int.Parse(campos[2]);
                    banda.ranking = int.Parse(campos[3]);
                    listadeBandas.Add(banda);
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
            Console.WriteLine("1 - Cadastrar bandas");
            Console.WriteLine("2 - Mostrar bandas");
            Console.WriteLine("3 - Buscar bandas por nome");
            Console.WriteLine("4 - Buscar bandas por genero");
            Console.WriteLine("5 - Buscar bandas por ranking");
            Console.WriteLine("6 - Alterar banda");
            Console.WriteLine("7 - Excluir banda");
            Console.WriteLine("0 - Sair");
            int op = int.Parse(Console.ReadLine());

            return op;
        }

        static void Main()
        {

            List<tipoBanda> listadeBandas = new List<tipoBanda>();

            int op;

            carregarDados(listadeBandas, "dados.txt");

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

                    case 5:

                        Console.Write("Digite o ranking da banda: ");
                        int ranking = int.Parse(Console.ReadLine());
                    
                        searchBandasRanking(listadeBandas, ranking);

                        break;

                    case 6:

                        Console.Write("Digite o nome da banda a ser alterado: ");
                        string nomeAlter = Console.ReadLine();

                        alterBanda(listadeBandas, nomeAlter);

                        break;

                    case 7:

                        Console.Write("Digite o nome da banda a ser excluído: ");
                        string nomeDel = Console.ReadLine();

                        deleteBanda(listadeBandas, nomeDel);

                        break;

                    case 0:

                        salvarDados(listadeBandas, "dados.txt");
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
