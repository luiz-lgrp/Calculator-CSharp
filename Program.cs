using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           Menu();
        }

         static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Olá, seja bem-vindo(a)!");
            Console.WriteLine("Qual operação deseja fazer?");

            Console.WriteLine("");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("----------------------");
            Console.WriteLine("Selecione uma opção:");
            
            short resposta = short.Parse(Console.ReadLine());
            Console.WriteLine("----------------------");

            switch (resposta)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: Console.WriteLine("Obrigado por usar o nosso sistema!"); System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        
         static void Soma()
         {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            Double v1 = Double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Segundo Valor: ");
            Double v2 = Double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            var resultado = v1+ v2;
            Console.WriteLine($"O resultado da soma é {resultado}");

            Console.ReadKey();
            Menu();
         }

         static void Subtracao()
         {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            Double v1 = Double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Segundo Valor: ");
            Double v2 = Double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            var resultado = v1-v2;  
            Console.WriteLine($"O resultado da subtração é {resultado}");

            Console.ReadKey();
            Menu();
         }

         static void Divisao()
         {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            Double v1 = Double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Segundo Valor: ");
            Double v2 = Double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            var resultado = v1/v2;  
            Console.WriteLine($"O resultado da divisão é {resultado}");

            Console.ReadKey();
            Menu();
         }

         static void Multiplicacao()
         {
            Console.Clear();

            Console.WriteLine("Primeiro Valor:");
            Double v1 = Double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Segundo Valor:");
            Double v2 = Double.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            var resultado = v1*v2;  
            Console.WriteLine($"O resultado da multiplicação é {resultado}");

            Console.ReadKey();
            Menu();
         }

    }
     
   

    
}
