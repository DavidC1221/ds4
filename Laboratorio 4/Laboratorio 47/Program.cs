using System;
namespace Laboratorio_47
{
    internal class Program
    {
        // Lab 4.7 - Métodos con parámetros opcionales
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 4.7 · Métodos con parámetros opcionales");
            int numeroUno = 7;
            double numeroDos = 7.89;
            double numeroTres = 0.59;
            Console.WriteLine(Suma(numeroUno, numeroDos, numeroTres));
            Console.WriteLine(Suma(numeroUno, numeroDos)); // uso con parámetro opcional
            Console.ReadKey();
        }

        static double Suma(int x, double y, double z = 0)
        {
            return x + y + z;
        }
    }
}
