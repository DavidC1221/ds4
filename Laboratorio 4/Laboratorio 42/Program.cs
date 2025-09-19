using System;
namespace Laboratorio_42
{
    internal class Program
    {
        // Lab 4.2 - FOR: factorial de un número entero
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 4.2 · FOR (factorial)");
            int fac, n;
            string linea;
            Console.Write("Ingrese un numero entero: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            fac = 1;
            for (int i = 1; i <= n; i++)
            {
                fac = fac * i;
            }
            Console.WriteLine("La factorial es: " + fac);
            Console.WriteLine("Fin. Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
