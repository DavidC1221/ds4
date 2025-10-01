using Laboratorio94;
using System;

namespace Laboratorio95
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("=== Problema 5: Arreglo NO repetido entre dos números aleatorios ===");
            Aleatorios a = new Aleatorios();

            int n1 = a.GenerarNumero(1, 100);
            int n2 = a.GenerarNumero(1, 100);
            int min = Math.Min(n1, n2);
            int max = Math.Max(n1, n2);

            int rango = max - min + 1;
            int cantidad = Math.Min(10, rango);

            var arr = a.GenerarArregloNoRepetidos(min, max, cantidad);

            Console.WriteLine($"Límites aleatorios: min={min}, max={max} | cantidad={cantidad}");
            Console.WriteLine("Arreglo sin repetidos:");
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
