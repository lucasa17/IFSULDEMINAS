/*
2. Escreva um programa que solicite ao usuário uma palavra (string) e uma letra(char).
O programa deve contar e exibir quantas vezes a letra aparece na palavra, 
ignorando se está em maiúsculas ou minúsculas. 
Para ler a variável letra do tipo char: letra = Console.ReadLine()[0];       
Para deixar maisculas:  palavra = palavra.ToUpper(); letra = Char.ToUpper(letra);
*/

using System;

class HelloWorld {

  static void Main() {

   
      int cont = 0;

    Console.WriteLine("Digite uma palavra: ");
    string palavra = Console.ReadLine();
    
    Console.WriteLine("Digite um caracter: ");
    char letra = char.Parse(Console.ReadLine());
    
    palavra = palavra.ToUpper();
    letra = Char.ToUpper(letra);
    
        for (int i = 0; i < palavra.Length; i++){
            
            if(palavra[i] == letra){
                
                cont++;
                
            }
            
        }
        
        Console.WriteLine("A letra "+ letra + " aparece "+ cont +" vezes na palavra "+ palavra); 


  }
}
