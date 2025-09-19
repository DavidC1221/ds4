using System;
namespace Laboratorio_4
{
    internal class Program
    {
        // Lab 4.1 - WHILE: imprimir consecutivamente de 1 hasta n
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 4.1 · WHILE");
            int n, x;
            string linea;
            Console.Write("Ingrese el valor de n: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            x = 1;
            while (x <= n)
            {
                Console.Write(x);
                Console.Write(" ");
                x = x + 1;
            }
            Console.WriteLine();
            Console.WriteLine("Fin. Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
