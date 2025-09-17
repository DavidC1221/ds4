using System;

namespace Laboratorio32
{
    public class CalculosMatematicos
    {
        public double CalculoArea(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Introduce el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            CalculosMatematicos calc = new CalculosMatematicos();
            double area = calc.CalculoArea(radio);

            Console.WriteLine($"El área del círculo es: {area}");
        }
    }
}
