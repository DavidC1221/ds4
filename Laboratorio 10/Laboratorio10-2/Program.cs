using System;

namespace Laboratorio10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1415926;
            Console.Write("Ingrese el radio: ");
            double radio = double.Parse(Console.ReadLine());

            double area = PI * Math.Pow(radio, 2);
            double circunferencia = 2 * PI * radio;

            Console.WriteLine("El área es: {0}", area);
            Console.WriteLine("La circunferencia es: {0}", circunferencia);
            Console.ReadKey();
        }
    }
}