using System;

namespace AreadoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a base do triangulo retângulo: ");
            string valordaBase = Console.ReadLine();
            double numerodaBase = Double.Parse(valordaBase);

            Console.WriteLine();

            Console.Write("Digite a altura do triangulo retângulo:");
            string valordaAltura = Console.ReadLine();
            double numerodaAltura = Double.Parse(valordaAltura);

            double valordaArea = (numerodaBase*numerodaAltura)/2;

            Console.WriteLine();

            Console.WriteLine("Área do Triangulo Retângulo é: " + valordaArea);
        }
    }
}
