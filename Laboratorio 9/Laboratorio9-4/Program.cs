using System;

namespace Laboratorio94
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("=== Problema 4: Probar clase Aleatorios ===");
            Aleatorios a = new Aleatorios();
            Console.WriteLine("Número entre 10 y 20: " + a.GenerarNumero(10, 20));
            var arreglo = a.GenerarArreglo(1, 6, 10);
            Console.WriteLine("Arreglo (con repetidos) [1..6], 10 elementos:");
            Console.WriteLine(string.Join(", ", arreglo));
        }
    }
}
