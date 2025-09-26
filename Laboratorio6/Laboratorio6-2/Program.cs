using System;

namespace Laboratorio6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite el número deseado:");

            try
            {
                num = Int16.Parse(Console.ReadLine()!);
            }
            catch (FormatException)
            {
                Console.WriteLine("No se ha introducido un dígito válido");
                num = -1;
            }
            catch (OverflowException)
            {
                Console.WriteLine("El número introducido es muy grande");
                num = -1;
            }

            Console.WriteLine(num);
        }
    }
}
