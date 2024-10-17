/*Receber um vetor de N posições do tipo inteiro verificar quantas vezes um dado valor informado pelo usuário
se encontra no vetor. Apresente também todos elementos do vetor.*/

using System;
using Arrays;

class Exercicio9
{

    static int procuraVetor(int[] vetor1)
    {

        Console.Write("Digite um valor: ");
        int num = int.Parse(Console.ReadLine());
        
        int cont = 0;
        
        
        for (int i = 0; i < vetor1.Length; i++)
        {
            
            if(vetor1[i] == num){
                
                Console.WriteLine(vetor1[i] + " está na posição " + i + "° do vetor.");
                
                cont++;
            }

        }
        
        return cont;   
        
    }

    static void Main()
    {

        int[] vetor1;


        Console.Write("Digite quantos valores deseja nos vetores: ");
        int quant = int.Parse(Console.ReadLine());

        vetor1 = new int[quant];//declando vetor 


        BibliotecaArray.randomArray(vetor1);

        int cont = procuraVetor(vetor1);
        
        BibliotecaArray.showArray(vetor1);


        if(cont > 0){
            
            Console.Write("\n\nO valor aparece "+cont+" vezes no vetor");
            
        }
        else{
            
            Console.Write("\n\nO valor não aparece no vetor");
        }
    }

}

