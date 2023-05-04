using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string parOuImpar;

            Console.Write("Entre com um número inteiro: ");
            x = int.Parse(Console.ReadLine()!);

            parOuImpar = x % 2 == 0 ? "PAR!" : "IMPAR!";

            Console.WriteLine($"O valor é {parOuImpar}");
        }
    }
}