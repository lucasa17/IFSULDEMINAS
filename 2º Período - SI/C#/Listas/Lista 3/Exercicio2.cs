/*
Faça um programa que:
a. Crie uma estrutura para armazenar dados de livros em uma biblioteca: título
(30 letras), autor (15 letras) e ano, prateleira.
b. Permita cadastrar livros.
c. Procure um livro por título, perguntando ao usuário qual tıtulo deseja buscar,
apresente o nome e em qual prateleira o mesmo se encontra.
d. Mostre os dados de todos os livros cadastrados.
e. Leia um ano e apresente todos os livros mais novos que o ano lido.
*/

using System;
using System.IO;


class Biblioteca
{

    public string titulo;
    public string autor;
    public int ano;
    public int prateleira;

}


class Exercicio2{

    static void addLivro(List<Biblioteca> itensBiblioteca)
    {

        Biblioteca itens = new Biblioteca();

        Console.WriteLine("Dados do livro:");

        Console.Write("Título:");
        itens.titulo = Console.ReadLine();

        Console.Write("Autor:");
        itens.autor = Console.ReadLine();

        Console.Write("Ano:");
        itens.ano = int.Parse(Console.ReadLine());

        Console.Write("Prateleira:");
        itens.prateleira = int.Parse(Console.ReadLine());

            itensBiblioteca.Add(itens);
            Console.WriteLine("Dados adicionados com sucesso!");

    }

    static void showLivros(List<Biblioteca> itensBiblioteca)
    {

        Console.WriteLine("\nLivros cadastrados: ");

        for (int i = 0; i < itensBiblioteca.Count; i++)
        {

            Console.WriteLine("Livro " + (i + 1));

            Console.WriteLine("Título: " + itensBiblioteca[i].titulo);
            Console.WriteLine("Autor: " + itensBiblioteca[i].autor);
            Console.WriteLine("Ano: " + itensBiblioteca[i].ano);
            Console.WriteLine("Prateleira: " + itensBiblioteca[i].prateleira);

            Console.WriteLine("\n");
        }

    }
    static void searchLivroTitulo(List<Biblioteca> itensBiblioteca, string titulo)
    {
        int cont = 0;

        for (int i = 0; i < itensBiblioteca.Count; i++)
        {

            if (itensBiblioteca[i].titulo.ToUpper().Equals(titulo.ToUpper()))
            {

                Console.WriteLine("Livro " + (i + 1));

                Console.WriteLine("Título: " + itensBiblioteca[i].titulo);
                Console.WriteLine("Autor: " + itensBiblioteca[i].autor);
                Console.WriteLine("Ano: " + itensBiblioteca[i].ano);
                Console.WriteLine("Prateleira: " + itensBiblioteca[i].prateleira);

                Console.WriteLine("\n");

                cont++;
            }


        }

        if (cont == 0)
        {

            Console.WriteLine("Banda não encontrada");

        }

    }

    static void searchLivrosAno(List<Biblioteca> itensBiblioteca, int ano)
    {
        int cont = 0;

        Console.WriteLine("Livros mais novos que o ano lido:");

        for (int i = 0; i < itensBiblioteca.Count; i++)
        {

            if (itensBiblioteca[i].ano < ano)
            {

                Console.WriteLine("Banda " + (i + 1));

                Console.WriteLine("Título: " + itensBiblioteca[i].titulo);
                Console.WriteLine("Autor: " + itensBiblioteca[i].autor);
                Console.WriteLine("Ano: " + itensBiblioteca[i].ano);
                Console.WriteLine("Prateleira: " + itensBiblioteca[i].prateleira);

                Console.WriteLine("\n");

                cont++;
            }


        }

        if (cont == 0)
        {

            Console.WriteLine("Nenhuma banda encontrada");

        }

    }
    static void salvarDados(List<Biblioteca> itensBiblioteca, string nomeArquivo)
    {
        StreamWriter writer = new StreamWriter(nomeArquivo);

        foreach (Biblioteca itens in itensBiblioteca)
        {
            writer.WriteLine($"{itens.titulo},{itens.autor},{itens.ano},{itens.prateleira}");
        }

        Console.WriteLine("Dados salvos com sucesso!");
        writer.Dispose();
    }
    static void carregarDados(List<Biblioteca> itensBiblioteca, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(',');
                Biblioteca itens = new Biblioteca();
                itens.titulo = campos[0];
                itens.autor = campos[1];
                itens.ano = int.Parse(campos[2]);
                itens.prateleira = int.Parse(campos[3]);
                itensBiblioteca.Add(itens);
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
        Console.WriteLine("1 - Cadastrar livros");
        Console.WriteLine("2 - Mostrar livros");
        Console.WriteLine("3 - Buscar livro por nome");
        Console.WriteLine("4 - Buscar livro por ano");
        Console.WriteLine("0 - Sair");
        int op = int.Parse(Console.ReadLine());

        return op;

    }
    static void Main()
    {

        List<Biblioteca> itensBiblioteca = new List<Biblioteca>();

        int op;

        carregarDados(itensBiblioteca, "dadosBiblioteca.txt");

        do
        {

            op = menu();

            switch(op){

                case 1:

                    Console.Write("Digite o título do livro: ");

                    addLivro(itensBiblioteca);
                    
                break;

                case 2:

                    showLivros(itensBiblioteca);

                break;

                case 3:

                    Console.Write("Digite o título do livro: ");

                    string titulo = Console.ReadLine();

                    searchLivroTitulo(itensBiblioteca, titulo);

                break;

                case 4:

                    Console.Write("Digite o ano que deseja: ");

                    int ano = int.Parse(Console.ReadLine());

                    searchLivrosAno(itensBiblioteca, ano);

                    break;

                case 0:

                    salvarDados(itensBiblioteca, "dadosBiblioteca.txt");
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


