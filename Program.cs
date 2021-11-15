using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)

        {

            menu();

        }
        static void menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("======================");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());


            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: multiplicacao(); break;
                case 4: divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: menu(); break;
            }
        }
        static void multiplicacao()

        {

            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float miltiplica = v1 * v2;
            Console.WriteLine();
            Console.WriteLine(miltiplica);
            Console.ReadKey();
            menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é: {resultado} ");
            Console.WriteLine(resultado);
            Console.ReadKey();
            menu();
        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da subtração é: {resultado} ");
            Console.WriteLine(resultado);
            Console.ReadKey();
            menu();
        }
        static void divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da subtração é: {resultado} ");
            Console.WriteLine(resultado);
            Console.ReadKey();


        }
    }
}
