using System;
using System.Collections.Generic;
// Lab 5-6: diccionario país–capital
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> paisesCapitales = new()
        {
            { "Francia", "París" },
            { "España", "Madrid" },
            { "Perú", "Lima" },
            { "Panamá", "Ciudad de Panamá" }
        };

        foreach (KeyValuePair<string, string> par in paisesCapitales)
        {
            Console.WriteLine($"La capital de {par.Key} es {par.Value}.");
        }
    }
}
