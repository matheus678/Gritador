using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva qualquer coisa: ");
            string texto = Console.ReadLine();

            Console.Write (texto.ToUpper());
        }
    }
}
