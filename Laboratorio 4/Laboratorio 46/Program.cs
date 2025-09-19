using System;
namespace Laboratorio_46
{
    internal class Program
    {
        // Lab 4.6 - Constantes y uso de Math: área de un círculo
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 4.6 · Constantes y uso de Math");
            Console.Write("Digite el radio del círculo: ");
            double radio = double.Parse(Console.ReadLine());
            double area = Math.Pow(radio, 2) * Math.PI;
            Console.WriteLine("El área del círculo es: " + area);
            Console.ReadKey();
        }
    }
}
