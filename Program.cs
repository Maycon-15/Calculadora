using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string Escolha = "";

            do 
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n------CALCULADORA------");
                Console.ResetColor();

                Console.WriteLine("\nOlá usuário, escolha uma das opções de equação abaixo:\n");

                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Radiciação");
                Console.WriteLine("6 - Exponenciação\n");
                
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Sair - (S)im / (N)ão");
                Console.ResetColor();

                Console.Write("\nDigite o número que corresponde a sua escolha: ");
                Escolha = Console.ReadLine().ToUpper();


                switch(Escolha)
                {
                    case "1":
                    Adição();
                    break;

                    case "2":
                    Subtração();
                    break;

                    case "3":
                    Multiplicação();
                    break;

                    case "4":
                    Divisão();
                    break;

                    case "5":
                    Radiciação();
                    break;

                    case "6":
                    Exponenciação();
                    break;

                }
            } while (Escolha != "S");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n----Sobre----\n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Meu nome é Maycon, tenho 16 anos e estou no 1° módulo de informatica na Etec Adolpho erezin.");
                Console.WriteLine("\neste trabalho foi feito com intenção de colocar em prática o que aprendi durante o curso.");
                Console.ResetColor();

        }
        static void Adição()
        {
            decimal Numero1, Numero2, Result;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n----Adição----");
            Console.ResetColor();

            Console.WriteLine("\nDigite abaixo dois números que serão usados na soma\n");

            Console.Write("Digite o primeiro número: ");
            Numero1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write($"\nDigite o segundo número: ");
            Numero2 = Convert.ToDecimal(Console.ReadLine());

            Result = Numero1 + Numero2;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\n{Numero1} + {Numero2} = {Result}");
            Console.ResetColor();

            Console.Write("\nPresione qualquer tecla para continuar: ");
            Console.ReadKey();
        }
        static void Subtração()
        {
            decimal Numero1, Numero2, Result;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n----Subtração----");
            Console.ResetColor();

            Console.WriteLine("\nDigite abaixo os dois números que serão utilizados na subtração\n");

            Console.Write("Digite o primeiro número: ");
            Numero1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\nDigite o segundo número: ");
            Numero2 = Convert.ToDecimal(Console.ReadLine());

            Result = Numero1 - Numero2;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\n{Numero1} + {Numero2} = {Result}");
            Console.ResetColor();

            Console.Write("\nPresione qualquer tecla para continuar: ");
            Console.ReadKey();
        }
        static void Multiplicação()
        {
            decimal Numero1, Numero2, Result;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n----Multiplicação----");
            Console.ResetColor();
            
            Console.WriteLine("\nDigite abaixo os dois números que serão utilizados na multiplicação\n");

            Console.Write("Digite o primeiro número: ");
            Numero1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\nDigite o segundo número: ");
            Numero2 = Convert.ToDecimal(Console.ReadLine());

            Result = Numero1 * Numero2;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\n{Numero1} X {Numero2} = {Result:N2}");
            Console.ResetColor();

            Console.Write("\nPresione qualquer tecla para continuar: ");
            Console.ReadKey();
        }
        static void Divisão()
        {
            decimal Numero1, Numero2, Result;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n----Divisão----");
            Console.ResetColor();
            
            Console.WriteLine("\nDigite abaixo os dois números que serão utilizados na divisão\n");

            Console.Write("Digite o primeiro número: ");
            Numero1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\nDigite o segundo número: ");
            Numero2 = Convert.ToDecimal(Console.ReadLine());

            Result = Numero1 / Numero2;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\n{Numero1} / {Numero2} = {Result:N2}");
            Console.ResetColor();

            Console.Write("\nPresione qualquer tecla para continuar: ");
            Console.ReadKey();
        }
        static void Radiciação()
        {
            Double Opcao;
            Double Raiz;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n----Radiciação----");
            Console.ResetColor();

            Console.Write("\nDigite um numero inteiro e positivo: ");
            Opcao = Convert.ToDouble(Console.ReadLine());

            if (Opcao >= 0)
            {
                Raiz = Math.Sqrt(Opcao);

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"\n A raíz de {Opcao} é: {Raiz:N2}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nNúmero invalido!");
                Console.ResetColor();
            }
            Console.WriteLine("\nDigite qualquer tecla para continuar: ");
            Console.ReadKey(); 
        }
        static void Exponenciação()
        {
            Double Potencia, NumeroElevado, NumeroExpoente;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n----Exponenciação----\n");
            Console.ResetColor();

            Console.Write("Digite o número que será elevado: ");
            NumeroElevado = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            NumeroExpoente = Convert.ToDouble(Console.ReadLine());

            Potencia = Math.Pow(NumeroElevado, NumeroExpoente);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\n{NumeroElevado} elevado a {NumeroExpoente} é igual a: {Potencia:N2}\n");
            Console.ResetColor();

            Console.WriteLine("Digite qualquer tecla para continuar: ");
            Console.ReadKey(); 
        }
    }
}
