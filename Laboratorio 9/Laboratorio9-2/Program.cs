using System;
using System.Linq;

namespace Laboratorio92
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("=== Problema 2: Números del 1 al 100 (pares o divisibles entre 3) ===");
            var nums = Enumerable.Range(1, 100)
                                 .Where(n => n % 2 == 0 || n % 3 == 0)
                                 .ToArray();
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}
