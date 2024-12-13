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
    public int emprestimo;

}

class emprestimo
{

    public string data;
    public string nomePessoa;
    public char pessoa;

}


class Exercicio4
{

    static Main()
    {


    }

}
