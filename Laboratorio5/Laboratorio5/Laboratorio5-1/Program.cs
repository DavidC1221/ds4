using System;

namespace Laboratorio5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sueldos = new int[5];
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.Write($"Ingrese sueldo del operario #{i + 1}: ");
                string? linea = Console.ReadLine();
                if (!int.TryParse(linea, out sueldos[i]))
                {
                    Console.WriteLine("Entrada inválida. Se asigna 0.");
                    sueldos[i] = 0;
                }
            }

            Console.WriteLine("\nLos 5 sueldos de los operarios:");
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine($"[{i}] {sueldos[i]}");
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
