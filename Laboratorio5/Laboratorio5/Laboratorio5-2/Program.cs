using System;

namespace Laboratorio5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3,4];
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write($"Ingrese posición [{f},{c}]: ");
                    string? linea = Console.ReadLine();
                    if (!int.TryParse(linea, out mat[f,c]))
                    {
                        Console.WriteLine("Entrada inválida. Se asigna 0.");
                        mat[f,c] = 0;
                    }
                }
            }

            Console.WriteLine("\nMatriz ingresada:");
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(mat[f,c] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
