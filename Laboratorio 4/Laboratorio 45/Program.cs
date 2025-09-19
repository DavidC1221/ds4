using System;
namespace Laboratorio_45
{
    internal class Program
    {
        // Lab 4.5 - Multi-inicialización de variables
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 4.5 · Multi-inicialización de variables");
            // Declaración de variables
            int edad1;
            int edad2;
            int edad3;
            int edad4, edad5;
            // Inicialización de variables
            edad1 = 18;
            edad2 = 31;
            edad3 = 25;
            edad4 = 20; edad5 = 30;
            Console.WriteLine("{0} , {1} , {2} , {3} , {4}", edad1, edad2, edad3, edad4, edad5);
            Console.WriteLine("Fin. Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
