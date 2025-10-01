using System;

namespace Laboratorio93
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("=== Problema 3: Clasificar triángulo ===");
            double a = Leer("Lado a: ");
            double b = Leer("Lado b: ");
            double c = Leer("Lado c: ");

            double[] lados = new[] { a, b, c };
            Array.Sort(lados);
            a = lados[0]; b = lados[1]; c = lados[2];

            if (a + b <= c)
            {
                Console.WriteLine("No forman un triángulo válido (a + b debe ser > c).");
                return;
            }

            string tipo = (a == b && b == c) ? "Equilátero" :
                          (a == b || b == c || a == c) ? "Isósceles" : "Escaleno";

            bool recto = Math.Abs(a * a + b * b - c * c) < 1e-9;

            Console.WriteLine($"Tipo: {tipo}" + (recto ? " y Rectángulo" : ""));
        }

        static double Leer(string msg)
        {
            double v;
            Console.Write(msg);
            while (!double.TryParse(Console.ReadLine(), out v) || v <= 0)
            {
                Console.Write("Valor inválido. " + msg);
            }
            return v;
        }
    }
}
