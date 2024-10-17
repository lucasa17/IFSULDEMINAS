using System;

class Exercicio12{
    
        
        static void notasVetor(string notas){
             
        string[] notasArray = notas.Split(' ');


            double[] valores = new double[notasArray.Length];

            for(int i = 0; i < notasArray.Length; i++){
                
                valores[i] = double.Parse(notasArray[i]);

            }
            
            
                double maior = valores[0];
                double menor = valores[0];
        
    
                for (int i = 1; i < valores.Length; i++){
                    
                    if (valores[i] > maior){
                        
                        maior = valores[i];
                        
                    }
                    
                    if (valores[i] < menor){
                        
                        menor = valores[i];
                        
                    }
                }
            
                    double soma = 0;
                    
                    for (int i = 1; i < valores.Length; i++){
                        
                        if(valores[i] != maior && valores[i] != menor){
                            
                            soma = soma + valores[i];
                            
                        }
                        
                    }
            
        Console.WriteLine(soma);
        
        }
            
    static void Main(){
        
        
        Console.WriteLine("Digite as notas: ");
        Console.WriteLine("ex:9.2 9.0 8.5");
        string notas = Console.ReadLine();

        notasVetor(notas);

        
    }
}



 
