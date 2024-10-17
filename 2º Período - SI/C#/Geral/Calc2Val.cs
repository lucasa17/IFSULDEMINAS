using System;

class Program{
    
    static float somar(float a, float b){

        float soma = a + b;
        
        return soma;
        //return soma = a + b;
    }

    static float subtrair(float a, float b)
    {

        float sub = a - b;

        return sub;
        //return sub = a + b;
    }

    static float multiplica(float a, float b)
    {

        float mult = a * b;

        return mult;
    }

    static float divide(float a, float b)
    {

        float div = a / b;

        return div;
    }

    static void Main(){

            float a, b;
            string escolha = "1";

        while (escolha != "0"){

            Console.WriteLine("Digite dois valores:");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());


            Console.WriteLine("Escolha a operação:\n + = Soma \t - = Subtração \t * = Multiplicação \t / = Divisão");
            escolha = Console.ReadLine();

            switch (escolha)
            {

                case ("+"):

                    float soma = somar(a, b);
                    Console.WriteLine(a + " + " + b + " = " + Math.Round(soma, 2));
                    
                    Console.WriteLine("\nDeseja continuar: 1 - Sim\t0 - Não");
                    escolha = Console.ReadLine();

                    break;

                case ("-"):

                    float sub = subtrair(a, b);
                    Console.WriteLine(a + " - " + b + " = " + Math.Round(sub, 2));
                    
                    Console.WriteLine("\nDeseja continuar: 1 - Sim\t0 - Não");
                    escolha = Console.ReadLine();

                    break;

                case ("*"):

                    float mul = multiplica(a, b);
                    Console.WriteLine(a + " * " + b + " = " + Math.Round(mul, 2));
                    
                    Console.WriteLine("\nDeseja continuar: 1 - Sim\t0 - Não");
                    escolha = Console.ReadLine();

                    break;

                case ("/"):

                    float div = divide(a, b);
                    Console.WriteLine(a + " / " + b + " = " + Math.Round(div, 2));
                    
                    Console.WriteLine("\nDeseja continuar: 1 - Sim\t0 - Não");
                    escolha = Console.ReadLine();

                    break;

            }

        }
        }

}
