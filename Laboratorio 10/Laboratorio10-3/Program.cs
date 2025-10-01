using System;

namespace Laboratorio10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double G = 9.8;
            Console.Write("Ingrese la masa del objeto: ");
            double M = double.Parse(Console.ReadLine());

            double P = M * G;

            Console.WriteLine("Peso del objeto: {0}", P);
            Console.ReadKey();
        }
    }
}