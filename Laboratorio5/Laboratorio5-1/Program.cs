using System;
// Lab 5-1: sueldos en arreglo (int[])
class Program
{
    static void Main(string[] args)
    {
        int[] sueldos = new int[5];
        for (int i = 0; i < sueldos.Length; i++)
        {
            Console.Write($"Ingrese sueldo del operario #{i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out sueldos[i]))
            {
                Console.Write("Valor inválido. Intente de nuevo: ");
            }
        }

        Console.WriteLine("\nLos 5 sueldos ingresados:");
        for (int i = 0; i < sueldos.Length; i++)
        {
            Console.WriteLine($"[{i}] = {sueldos[i]}");
        }
    }
}
