using System;

namespace Laboratorio33
{
    public class CalculosMatematicos
    {
        public int CalculoPerimetro(int lado1, int lado2)
        {
            return 2 * (lado1 + lado2);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Introduce el lado 1 del rectángulo: ");
            int lado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el lado 2 del rectángulo: ");
            int lado2 = Convert.ToInt32(Console.ReadLine());

            CalculosMatematicos calc = new CalculosMatematicos();
            int perimetro = calc.CalculoPerimetro(lado1, lado2);

            Console.WriteLine($"El perímetro del rectángulo es: {perimetro}");
        }
    }
}
