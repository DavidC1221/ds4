using System;
namespace Laboratorio_44
{
    internal class Program
    {
        // Lab 4.4 - Condicionales IF/ELSE: evaluar nota >= 70
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 4.4 · IF/ELSE (condicionales)");
            Console.Write("Ingrese la nota del estudiante: ");
            float score = float.Parse(Console.ReadLine());
            if (score >= 70)
            {
                Console.WriteLine();
                Console.WriteLine("Su nota es {0} ha aprobado", score);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Su nota es {0} ha reprobado, debe repetir", score);
            }
            Console.ReadKey();
        }
    }
}
