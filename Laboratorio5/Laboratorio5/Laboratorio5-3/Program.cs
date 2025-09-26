using System;

namespace Laboratorio5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = { "manzana", "plátano", "naranja" };
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
