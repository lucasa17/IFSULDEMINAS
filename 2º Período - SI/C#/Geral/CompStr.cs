/*
1. Escreva um programa que solicite ao usuário dois textos 
e compare se as strings são iguais, 
ignorando a diferença entre maiúsculas e minúsculas. 
O programa também deve exibir a quantidade de caracteres de cada texto. 
Use os métodos string.Compare() e string.ToUpper().
*/

using System;

class HelloWorld {

  static void Main() {

    Console.WriteLine("Digite duas frases: ");
    string frase1 = Console.ReadLine();
    string frase2 = Console.ReadLine();
    
    int result = String.Compare(frase1.ToUpper(), frase2.ToUpper());
        
        if (result == 0) {

            Console.WriteLine("String iguais, tendo ambas "+ frase1.Length +" caracteres");

        }
        else {

            Console.WriteLine("String são diferentes. \nFrase 1: "+ frase1.Length +" caracteres \nFrase 2: "+ frase2.Length +" caracteres");

        } 

  }
}
