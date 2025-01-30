using System;
using System.IO;
using System.Collections.Generic;

class ItemConsumo
{
    public string nomeItem;
    public string tipoItem;
    public int quantidadeAtual;
    public double tamanhoConteudo;
    public int quantidadeMinima;
}

class Program
{
    static void adicionarItem(List<ItemConsumo> listaDeItens)
    {
        ItemConsumo novoItem = new ItemConsumo();
        Console.WriteLine("*** Dados do Item ***");
        Console.Write("Nome do Item: ");
        novoItem.nomeItem = Console.ReadLine();
        Console.Write("Tipo do Item (ex.: Reagente, Material Descartável, etc.): ");
        novoItem.tipoItem = Console.ReadLine();
        Console.Write("Quantidade Atual em Estoque: ");
        novoItem.quantidadeAtual = int.Parse(Console.ReadLine());
        Console.Write("Tamanho do Conteúdo por Unidade (ml ou gramas): ");
        novoItem.tamanhoConteudo = double.Parse(Console.ReadLine());
        Console.Write("Quantidade Mínima Desejada: ");
        novoItem.quantidadeMinima = int.Parse(Console.ReadLine());
        listaDeItens.Add(novoItem);
        Console.WriteLine("Item adicionado com sucesso!");
    }

    static void mostraItens(List<ItemConsumo> listaDeItens)
    {

        Console.WriteLine("Itens:\n");

        for (int i = 0; i < listaDeItens.Count; i++)
        {

            Console.WriteLine("\nItem " + (i + 1));

            Console.WriteLine("Nome: " + listaDeItens[i].nomeItem);

            Console.WriteLine("Tipo: " + listaDeItens[i].tipoItem);

            Console.WriteLine("Quantidade em Estoque: " + listaDeItens[i].quantidadeAtual);

            Console.WriteLine("Tamanho(ml ou gramas por un): " + listaDeItens[i].tamanhoConteudo);

            Console.WriteLine("Quantidade Mínima:" + listaDeItens[i].quantidadeMinima);

        }
    }


    static void atualizaEstoque(List<ItemConsumo> listaDeItens, string nome)
    {

        for (int i = 0; i < listaDeItens.Count; i++)
        {

            if (nome.Equals(listaDeItens[i].nomeItem))
            {

                Console.WriteLine("Nome: " + listaDeItens[i].nomeItem);

                Console.WriteLine("Tipo: " + listaDeItens[i].tipoItem);

                Console.WriteLine("Quantidade em Estoque: " + listaDeItens[i].quantidadeAtual);
                
                Console.WriteLine("Quantidade Mínima:" + listaDeItens[i].quantidadeMinima);

                Console.WriteLine("Entre com a quantidade para atualizar: ");
                int quantidade = int.Parse(Console.ReadLine());

                listaDeItens[i].quantidadeAtual += quantidade;

                Console.WriteLine("Estoque atualizado");
            }


        }

    }
    
    
    static void estoqueAbaixo(List<ItemConsumo> listaDeItens){
            
             for (int i = 0; i < listaDeItens.Count; i++)
        {

            if (listaDeItens[i].quantidadeAtual < listaDeItens[i].quantidadeMinima)
            {

                Console.WriteLine("\n\nNome: " + listaDeItens[i].nomeItem);

                Console.WriteLine("Tipo: " + listaDeItens[i].tipoItem);

                Console.WriteLine("Quantidade em Estoque: " + listaDeItens[i].quantidadeAtual);
                
                Console.WriteLine("Quantidade Mínima:" + listaDeItens[i].quantidadeMinima);


            }


        }
            
        }

    static void salvarDados(List<ItemConsumo> listaDeItens, string nomeArquivo)
    {
        StreamWriter writer = new StreamWriter(nomeArquivo);

        foreach (ItemConsumo item in listaDeItens)
        {
            writer.WriteLine($"{item.nomeItem},{item.tipoItem},{item.quantidadeAtual},{item.tamanhoConteudo},{item.quantidadeMinima}");
        }

        Console.WriteLine("Dados salvos com sucesso!");
        writer.Dispose();
    }

    static void carregarDados(List<ItemConsumo> listaDeItens, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            string[] linhas = File.ReadAllLines(nomeArquivo);
            foreach (string linha in linhas)
            {
                string[] campos = linha.Split(',');
                ItemConsumo item = new ItemConsumo();
                item.nomeItem = campos[0];
                item.tipoItem = campos[1];
                item.quantidadeAtual = int.Parse(campos[2]);
                item.tamanhoConteudo = double.Parse(campos[3]);
                item.quantidadeMinima = int.Parse(campos[4]);
                listaDeItens.Add(item);
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
        Console.WriteLine("*** Sistema de Controle de Estoque ***");
        Console.WriteLine("1 - Adicionar Item");
        Console.WriteLine("2 - Mostrar Itens");
        Console.WriteLine("3 - Atualizar estoque");
        Console.WriteLine("4 - Consultar itens com estoque abaixo");
        Console.WriteLine("0 - Sair");
        int op = int.Parse(Console.ReadLine());
        return op;
    }

    static void Main()
    {
        List<ItemConsumo> listaDeItens = new List<ItemConsumo>();
        int op;
        carregarDados(listaDeItens, "itens.txt");
        do
        {
            op = menu();
            switch (op)
            {
                case 1:

                    adicionarItem(listaDeItens);

                    break;

                case 2:
                    
                    mostraItens(listaDeItens);

                    break;

                case 3:

                    string nome;

                    Console.WriteLine("Digite o nome do item: ");
                    nome = Console.ReadLine();

                    atualizaEstoque(listaDeItens, nome);

                    break;
                    
                case 4:
                
                    estoqueAbaixo(listaDeItens);
                    
                    break;

                case 0:

                    Console.WriteLine("Saindo...");

                    salvarDados(listaDeItens, "itens.txt");

                    break;
            }
            
            Console.ReadKey();
            Console.Clear();
            
        } while (op != 0);
    }
}
