using System;
// Lab 5-2: matriz 3x4 (int[,]) con entrada y salida
class Program
{
    static void Main(string[] args)
    {
        int filas = 3, columnas = 4;
        int[,] mat = new int[filas, columnas];

        for (int f = 0; f < filas; f++)
        {
            for (int c = 0; c < columnas; c++)
            {
                Console.Write($"Ingrese posición [{f},{c}]: ");
                while (!int.TryParse(Console.ReadLine(), out mat[f, c]))
                {
                    Console.Write("Valor inválido. Intente de nuevo: ");
                }
            }
        }

        Console.WriteLine("\nMatriz ingresada:");
        for (int f = 0; f < filas; f++)
        {
            for (int c = 0; c < columnas; c++)
            {
                Console.Write(mat[f, c] + "\t");
            }
            Console.WriteLine();
        }
    }
}
