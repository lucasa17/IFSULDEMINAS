/*
 Desenvolver um sistema para catalogo e controle de coleções de jogos.
Crie e leia um vetor com dados de n jogos: título (30 letras), console (15
letras) ano, ranking e empréstimo.

O campo empréstimo é uma classe data que por sua vez, possui os campos:
o data
o nomePessoa
o emprestado (S/N)
a. Permita procurar o jogo por título, ou listar todos os jogos de um
console.
b. Permita realizar o empréstimo de um jogo, anotando a data atual, o
nome da pessoa que pegou o jogo e alterando o campo emprestado
para ‘S’.
c. Permita devolver o jogo definindo o campo emprestado para ‘N’.
d. Mostre todos os jogos que estão emprestados e para quem.
 */

using System;
using System.IO;

class jogos
{

    public string titulo;
    public string console;
    public int ano;
    public int ranking;

}

class emprestimo
{

    public string data;
    public string nomePessoa;
    public char emprestado;
    public int ranking;


}


class Exercicio4
{
    static void addJogo(List<jogos> listaJogos)
    {

        jogos jogo = new jogos();

        Console.WriteLine("\nDados do jogo:");

        Console.Write("Título:");
        jogo.titulo = Console.ReadLine();

        Console.Write("Console:");
        jogo.console = Console.ReadLine();

        Console.Write("Ano:");
        jogo.ano = int.Parse(Console.ReadLine());

        volta:

        Console.Write("Ranking:");
        jogo.ranking = int.Parse(Console.ReadLine());

        int cont = 0;

        for (int i = 0; i < listaJogos.Count; i++)
        {

            if (jogo.ranking == listaJogos[i].ranking)
            {
                Console.WriteLine("\nJá existe um jogo nesse ranking\n");

                Console.WriteLine("jogo " + (i + 1));

                Console.WriteLine("Título: " + listaJogos[i].titulo);
                Console.WriteLine("Console: " + listaJogos[i].console);
                Console.WriteLine("Ano: " + listaJogos[i].ano);
                Console.WriteLine("Ranking: " + listaJogos[i].ranking);

                Console.WriteLine("\n");

                cont++;
            }
        }

        if (cont != 1)
        {

            listaJogos.Add(jogo);
            Console.WriteLine("Dados adicionados com sucesso!");

        }
        else
        {
            Console.WriteLine("Digite outro ranking.");

            goto volta;

        }

    }


    static void searchJogoNome(List<jogos> listaJogos, string nome)
    {
        int cont = 0;

        for (int i = 0; i < listaJogos.Count; i++)
        {

            if (listaJogos[i].titulo.ToUpper().Equals(nome.ToUpper()))
            {

                Console.WriteLine("Jogo " + (i + 1));


                Console.WriteLine("Título: " + listaJogos[i].titulo);
                Console.WriteLine("Console: " + listaJogos[i].console);
                Console.WriteLine("Ano: " + listaJogos[i].ano);
                Console.WriteLine("Ranking: " + listaJogos[i].ranking);


                Console.WriteLine("\n");

                cont++;
            }


        }

        if (cont == 0)
        {

            Console.WriteLine("Jogo não encontrado");

        }

    }

    static void searchJogoConsole(List<jogos> listaJogos, string nome)
    {
        int cont = 0;

        for (int i = 0; i < listaJogos.Count; i++)
        {

            if (listaJogos[i].console.ToUpper().Equals(nome.ToUpper()))
            {

                Console.WriteLine("Jogo " + (i + 1));


                Console.WriteLine("Título: " + listaJogos[i].titulo);
                Console.WriteLine("Console: " + listaJogos[i].console);
                Console.WriteLine("Ano: " + listaJogos[i].ano);
                Console.WriteLine("Ranking: " + listaJogos[i].ranking);


                Console.WriteLine("\n");

                cont++;
            }


        }

        if (cont == 0)
        {

            Console.WriteLine("Jogo não encontrado");

        }

    }

    static void emprestimoJogo(List<jogos> listaJogos, List<emprestimo> listaEmprestimos, string nomeJ)
    {

        int cont = 0;

        for (int i = 0; i < listaJogos.Count; i++)
        {

            if (listaJogos[i].titulo.ToUpper().Equals(nomeJ.ToUpper()))
            {

                Console.WriteLine("Jogo " + (i + 1));


                Console.WriteLine("Título: " + listaJogos[i].titulo);
                Console.WriteLine("Console: " + listaJogos[i].console);
                Console.WriteLine("Ano: " + listaJogos[i].ano);
                Console.WriteLine("Ranking: " + listaJogos[i].ranking);


                Console.WriteLine("\n");

                emprestimo emprestimos = new emprestimo();

                Console.WriteLine("\nDados do emprestimo:");

                Console.Write("Nome da pessoa:");
                emprestimos.nomePessoa = Console.ReadLine();

                emprestimos.emprestado = 'S';
                emprestimos.ranking = listaJogos[i].ranking;

                DateTime dataAtual = DateTime.Now;
                emprestimos.data = dataAtual.ToString("dd-MM-yyyy HH:mm:ss");

                listaEmprestimos.Add(emprestimos);
                Console.WriteLine("Dados adicionados com sucesso!");

                cont++;
            }


        }

        if (cont == 0)
        {

            Console.WriteLine("Jogo não encontrado");

        }

    }

    static void searchEmprestimos(List<jogos> listaJogos, List<emprestimo> listaEmprestimos)
    {
        int cont = 0;

        for (int i = 0; i < listaJogos.Count; i++)
        {
            for (int j = 0; j < listaEmprestimos.Count; j++)
            {
                if (listaJogos[i].ranking.Equals(listaEmprestimos[j].ranking))
                {
                    if (listaEmprestimos[j].emprestado == 'S') // Apenas exibe se estiver emprestado
                    {
                        Console.WriteLine("Jogo " + (i + 1));
                        Console.WriteLine("Título: " + listaJogos[i].titulo);
                        Console.WriteLine("Console: " + listaJogos[i].console);
                        Console.WriteLine("Ano: " + listaJogos[i].ano);
                        Console.WriteLine("Ranking: " + listaJogos[i].ranking);
                        Console.WriteLine("Pessoa que emprestou: " + listaEmprestimos[j].nomePessoa);
                        Console.WriteLine("Data: " + listaEmprestimos[j].data);
                        Console.WriteLine("\n");
                        cont++;
                    }
                }
            }
        }

        if (cont == 0)
        {
            Console.WriteLine("Não há empréstimos ativos.");
        }
    }

    static void devolveJogo(List<jogos> listaJogos, List<emprestimo> listaEmprestimos, int rank)
    {
        bool encontrado = false;

        for (int j = 0; j < listaEmprestimos.Count; j++)
        {
            if (listaEmprestimos[j].ranking == rank && listaEmprestimos[j].emprestado == 'S')
            {
                // Atualiza o status do empréstimo para 'N'
                listaEmprestimos[j].emprestado = 'N';
                Console.WriteLine("Jogo devolvido com sucesso!");
                encontrado = true;
                break; // Saia do loop após encontrar e atualizar
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Jogo não encontrado ou já devolvido.");
        }
    }

    static void salvarDadosJ(List<jogos> listaJogos, string nomeArquivo)
    {
        StreamWriter writer = new StreamWriter(nomeArquivo);

        foreach (jogos jogo in listaJogos)
        {
            writer.WriteLine($"{jogo.titulo},{jogo.console},{jogo.ano},{jogo.ranking}");
        }

        Console.WriteLine("Dados salvos com sucesso!");
        writer.Dispose();
    }
    static void salvarDadosE(List<emprestimo> listaEmprestimos, string nomeArquivo)
    {
        StreamWriter writer = new StreamWriter(nomeArquivo);

        foreach (emprestimo emprestimos in listaEmprestimos)
        {
            writer.WriteLine($"{emprestimos.data},{emprestimos.nomePessoa},{emprestimos.emprestado},{emprestimos.ranking}");
        }

        Console.WriteLine("Dados salvos com sucesso!");
        writer.Dispose();
    }



    static void carregarDadosJ(List<jogos> listaJogos, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(',');
                jogos jogo = new jogos();
                jogo.titulo = campos[0];
                jogo.console = campos[1];
                jogo.ano = int.Parse(campos[2]);
                jogo.ranking = int.Parse(campos[3]);
                listaJogos.Add(jogo);
            }
            Console.WriteLine("Dados carregados com sucesso!");
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado :(");
        }
    }

    static void carregarDadosE(List<emprestimo> listaEmprestimos, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(',');
                emprestimo emp = new emprestimo();
                emp.data = campos[0];
                emp.nomePessoa = campos[1];
                emp.emprestado = char.Parse(campos[2]);
                emp.ranking = int.Parse(campos[3]);
                listaEmprestimos.Add(emp);
            }
            Console.WriteLine("Dados carregados com sucesso!");
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado :(");
        }
    }

    static void adicionaArquivoJ(List<jogos> listaJogos, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(',');
                jogos jogo = new jogos();
                jogo.titulo = campos[0];
                jogo.console = campos[1];
                jogo.ano = int.Parse(campos[2]);
                jogo.ranking = int.Parse(campos[3]);
                listaJogos.Add(jogo);
            }
            Console.WriteLine("Dados carregados com sucesso!");
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado :(");
        }
    }

    static void adicionaArquivoE(List<emprestimo> listaEmprestimos, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(',');
                emprestimo emp = new emprestimo();
                emp.data = campos[0];
                emp.nomePessoa = campos[1];
                emp.emprestado = char.Parse(campos[2]);
                emp.ranking = int.Parse(campos[3]);
                listaEmprestimos.Add(emp);
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
        Console.WriteLine("1 - Cadastrar jogo");
        Console.WriteLine("2 - Buscar jogo por título");
        Console.WriteLine("3 - Buscar jogos por console");
        Console.WriteLine("4 - Faça um emprestimo");
        Console.WriteLine("5 - Buscar um emprestimo");
        Console.WriteLine("6 - devolva o emprestimo");
        Console.WriteLine("7 - Carregue um arquivo com emprestimos");
        Console.WriteLine("8 - Carregue um arquivo com jogos");
        Console.WriteLine("0 - Sair");


        int op = int.Parse(Console.ReadLine());

        return op;
    }

    static void Main()
    {


        List<jogos> listaJogos = new List<jogos>();
        List<emprestimo> listaEmprestimo = new List<emprestimo>();

        int op;

        carregarDadosJ(listaJogos, "dadosJogos.txt");
        carregarDadosE(listaEmprestimo, "dadosEmprestimos.txt");


        do
        {

            op = menu();

            switch (op)
            {

                case 1:

                    addJogo(listaJogos);

                    break;

                case 2:

                    Console.Write("Digite o título do jogo: ");
                    string nome = Console.ReadLine();

                    searchJogoNome(listaJogos, nome);

                    break;

                case 3:

                    Console.Write("Digite o console: ");
                    string console = Console.ReadLine();

                    searchJogoConsole(listaJogos, console);

                    break;

                case 4:

                    Console.Write("Digite o jogo a ser emprestado: ");
                    string nomeJ = Console.ReadLine();

                    emprestimoJogo(listaJogos, listaEmprestimo, nomeJ);

                    break;

                case 5:

                    searchEmprestimos(listaJogos, listaEmprestimo);

                    break;

                case 6:

                    Console.Write("Digite o jogo a ser devolvido: ");
                    string nomeJD = Console.ReadLine();

                    int rank = 0;

                    for (int i = 0; i < listaJogos.Count; i++)
                    {

                        if (listaJogos[i].titulo.ToUpper().Equals(nomeJD.ToUpper()))
                        {

                            Console.WriteLine("Jogo " + (i + 1));


                            Console.WriteLine("Título: " + listaJogos[i].titulo);
                            Console.WriteLine("Console: " + listaJogos[i].console);
                            Console.WriteLine("Ano: " + listaJogos[i].ano);
                            Console.WriteLine("Ranking: " + listaJogos[i].ranking);


                            Console.WriteLine("\n");

                            rank = listaJogos[i].ranking;
                        }
                    }
                    
                        devolveJogo(listaJogos, listaEmprestimo, rank);

                    break;

                case 7:

                    Console.Write("Digite o nome do arquivo (inclua .txt): ");
                    string nomeArqu = Console.ReadLine();

                    adicionaArquivoE(listaEmprestimo, nomeArqu);
                    break;

                case 8:

                    Console.Write("Digite o nome do arquivo (inclua .txt): ");
                    string nomeArq = Console.ReadLine();

                    adicionaArquivoJ(listaJogos, nomeArq);

                    break;

                case 0:

                    salvarDadosE(listaEmprestimo, "dadosEmprestimos.txt");
                    salvarDadosJ(listaJogos, "dadosJogos.txt");
                    Console.WriteLine("Saindo.....");

                    break;

                default:

                    Console.WriteLine("Essa opção não existe");

                    break;

            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

            Console.Clear();

        } while (op != 0);

    }
}
