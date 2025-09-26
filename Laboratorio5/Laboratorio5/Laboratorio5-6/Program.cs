using System;
using System.Collections.Generic;

namespace Laboratorio5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> paisesYCapitales = new Dictionary<string,string>
            {
                ["Francia"] = "París",
                ["España"]  = "Madrid",
                ["Italia"]  = "Roma"
            };

            foreach (KeyValuePair<string,string> par in paisesYCapitales)
            {
                Console.WriteLine($"La capital de {par.Key} es {par.Value}.");
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
