using System;
using System.Collections.Generic;

namespace Laboratorio5_5
{
    class Estudiante
    {
        public string Nombre { get; set; } = "";
        public int Edad { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante { Nombre = "Ana",  Edad = 20 },
                new Estudiante { Nombre = "Pedro", Edad = 21 },
                new Estudiante { Nombre = "Johan", Edad = 19 }
            };

            foreach (Estudiante e in estudiantes)
            {
                Console.WriteLine($"Nombre: {e.Nombre}, Edad: {e.Edad}");
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
