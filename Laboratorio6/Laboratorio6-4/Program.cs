using System;

namespace Laboratorio6_4
{
    class Program
    {
        static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Acceso negado - No cumple con el criterio de edad");
            }
            else
            {
                Console.WriteLine("Acceso concedido");
            }
        }

        static void Main(string[] args)
        {
            CheckAge(15);
        }
    }
}
