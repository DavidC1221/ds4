using System;
using System.Collections.Generic;
// Lab 5-5: lista de objetos Estudiante
class Estudiante
{
    public string Nombre { get; set; } = "";
    public int Edad { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Estudiante> estudiantes = new()
        {
            new Estudiante { Nombre = "Ana",  Edad = 12 },
            new Estudiante { Nombre = "Juan", Edad = 10 },
            new Estudiante { Nombre = "Sofía", Edad = 11 }
        };

        foreach (var est in estudiantes)
        {
            Console.WriteLine($"Nombre: {est.Nombre}, Edad: {est.Edad}");
        }
    }
}
