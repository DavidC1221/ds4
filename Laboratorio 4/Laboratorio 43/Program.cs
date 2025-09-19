using System;
namespace Laboratorio_43
{
    internal class Program
    {
        // Lab 4.3 - DO-WHILE: promedio de valores ingresados (finaliza con 0)
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 4.3 · DO-WHILE (promedio)");
            int suma, cant, valor, promedio;
            string linea;
            suma = 0;
            cant = 0;
            do
            {
                Console.Write("Ingrese un número (0 para finalizar): ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor != 0)
                {
                    suma = suma + valor;
                    cant++;
                }
            } while (valor != 0);
            if (cant != 0)
            {
                promedio = suma / cant;
                Console.WriteLine("El promedio de los valores ingresados es: " + promedio);
                Console.WriteLine(promedio);
            }
            else
            {
                Console.WriteLine("No se ingresaron valores");
            }
            Console.WriteLine("Fin. Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
