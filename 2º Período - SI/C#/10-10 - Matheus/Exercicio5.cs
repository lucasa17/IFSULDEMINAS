/*Leia um vetor DNA de caracteres para receber as letras A, T, C e G que representam as bases do DNA. Este
vetor será responsável por representar uma fita de um gene de até 50 bases. Gere o vetor complementar ao
vetor DNA e o apresente (Lembrando as bases complementares A=T C=G).*/

using System;
using Arrays;

    class Exercicio5
    {

        static void dnaVetor(char[] vetor){


        char[] vetorComplementar;
        
        vetorComplementar = new char[vetor.Length];
        
        
            for (int i = 0; i < vetor.Length; i++)
            {

                if(Char.ToUpper(vetor[i]) == 'A'){
                    
                    vetorComplementar[i] = 'T';
                }
                
                if(Char.ToUpper(vetor[i]) == 'T'){
                    
                    vetorComplementar[i] = 'A';
                }
                
                if(Char.ToUpper(vetor[i]) == 'C'){
                    
                    vetorComplementar[i] = 'G';
                }
                
                if(Char.ToUpper(vetor[i]) == 'G'){
                    
                    vetorComplementar[i] = 'C';
                }
            }
    
            
            Console.WriteLine("\n\nDNA base original");
            
            for (int i = 0; i < vetor.Length; i++)
            {
                
            Console.Write("|"+Char.ToUpper(vetor[i])+"|");
            
            }
            
            
            Console.WriteLine("\n\nDNA base complementar: ");
            
            for (int i = 0; i < vetor.Length; i++)
            {
                
            Console.Write("|"+vetorComplementar[i]+"|");
            
            }
        }

        static void Main(){

        char[] vetor;

        Console.Write("Digite quantos valores deseja no vetor: ");
        int quant = int.Parse(Console.ReadLine());

        vetor = new char[quant];//declando vetor 

        BibliotecaArray.readArray(vetor);

        dnaVetor(vetor);        



    }
}
