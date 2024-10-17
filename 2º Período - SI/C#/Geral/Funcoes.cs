/*1.Crie
uma função chamada CalcularMedia
que receba três números float como
parâmetros e retorne a média aritmética desses números. No método Main,
solicite três números ao usuário, chame a função e exiba a média.


2.Crie
uma função chamada EhPrimo que
recebe um número inteiro como parâmetro e retorna um valor booleano indicando
se o número é primo ou não. No método Main,
solicite um número ao usuário e exiba se ele é primo.


3.Crie
uma função chamada CalcularFatorial
que receba um número inteiro positivo e retorne o fatorial desse número.


4.Crie
uma função chamada ConverterParaFahrenheit
que receba uma temperatura em graus Celsius como parâmetro e retorne o valor
convertido para Fahrenheit ((celsius * 9 / 5) + 32;).


5.Crie
uma função chamada CalcularPotencia
que receba dois números inteiros como parâmetros: a base e o expoente. A função
deve retornar o valor da base elevada ao expoente (base^expoente).
*/
using System;

class Program {
    
    static float CalcularMedia(float a, float b, float c){
         
         float media = (a + b +c)/3;
         
        return media;
         
    }
    
    static bool EhPrimo(int num){
         
        for(int i = 2; i < num; i++){
             
            if(num % i == 0){
                 
                return false;
            }
        }
         
        return true;
    }
    
    static int CalcularFatorial(int numf){
        
        int fatorial = 1;
        
            while (numf != 1)
            {
                fatorial = fatorial * numf;
                numf = numf - 1;
            }
            return fatorial;
    }
    
    static float ConverterParaFahrenheit(float celsius){
        
        float faren = (celsius * 9 / 5) + 32;
        
        return faren;
        
    }
    
    static double CalcularPotencia(double bas, double exp){
        
        double pot = Math.Pow(bas, exp);
        
        return pot; 
    }
     
     
      static void Main() {
          
        int escolha = 6;
        
        while(escolha != 0){
            
        Console.WriteLine("Escolha uma função: ");
        Console.WriteLine("1 - Calcular média\n2 - Número primo\n3 - Número fatorial\n4 - Temperatura em Fahrenheit\n5 - Calculo de potência\n0 - Sair");
        escolha = int.Parse(Console.ReadLine());
        
        
        switch(escolha){
            
            case 1:
            
                float a,b,c,media;
                
                Console.WriteLine("Digite 3 valores: ");
                a = float.Parse(Console.ReadLine());
                b = float.Parse(Console.ReadLine());
                c = float.Parse(Console.ReadLine());
                
                media = CalcularMedia(a, b, c);
                
                Console.WriteLine("Média: "+ media+"\n");
            
            break;
            
            case 2:
            
                int num;
                bool primo;
                
                Console.WriteLine("Digite um número: ");
                num = int.Parse(Console.ReadLine());
                
                primo = EhPrimo(num);
                
                Console.WriteLine(primo+"\n");
            
            break;
            
            case 3:
            
                int numf, fatorial;
                
                Console.WriteLine("Digite um número: ");
                numf = int.Parse(Console.ReadLine());
                
                fatorial = CalcularFatorial(numf);
                
                Console.WriteLine("Fatorial: "+fatorial+"\n");
                
            break;
            
            case 4:
            
                float celsius, faren;
                
                Console.WriteLine("Digite a temperatura em Celsius: ");
                celsius = float.Parse(Console.ReadLine());
                
                faren = ConverterParaFahrenheit(celsius);
                
                Console.WriteLine("Fahrenheit: "+faren+"\n");
    
            break;
            
            case 5:
            
                double bas, exp, pot;
                
                Console.WriteLine("Digite o valor da base: ");
                bas = double.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite o valor do expoente: ");
                exp = double.Parse(Console.ReadLine());
                
                pot = CalcularPotencia(bas, exp);
                
                Console.WriteLine("Potência: "+pot+"\n");
                
            break;
            
            case 0:
            
                Console.WriteLine("Obrigado por utilizar este programa.");
                
            break;
            
            default:
            
                Console.WriteLine("Código inexistente.\n");
            
            break;
    
        }
    
      }
    }
}
