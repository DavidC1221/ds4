using System;
using System.Text.RegularExpressions;

namespace Laboratorio9_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("=== Problema 1: Precio y forma de pago ===");

            decimal precio;
            while (true)
            {
                Console.Write("Ingrese el precio del producto (valor positivo): ");
                if (decimal.TryParse(Console.ReadLine(), out precio) && precio > 0)
                    break;
                Console.WriteLine("Valor inválido. Intente de nuevo...");
            }

            Console.Write("Forma de pago (E)fectivo / (T)arjeta: ");
            string? forma = Console.ReadLine()?.Trim().ToUpperInvariant();
            while (forma != "E" && forma != "T")
            {
                Console.Write("Opción inválida. Escriba E o T: ");
                forma = Console.ReadLine()?.Trim().ToUpperInvariant();
            }

            string detallePago;
            if (forma == "T")
            {
                string? tarjeta;
                var rgx = new Regex(@"^\d{16}$");
                do
                {
                    Console.Write("Ingrese el número de cuenta/tarjeta (16 dígitos): ");
                    tarjeta = Console.ReadLine()?.Trim();
                    if (tarjeta is null) tarjeta = "";
                } while (!rgx.IsMatch(tarjeta));

                detallePago = $"Tarjeta **** **** **** {tarjeta.Substring(12)}";
            }
            else
            {
                detallePago = "Efectivo";
            }

            Console.WriteLine("\n--- RECIBO ---");
            Console.WriteLine($"Monto: {precio:C}");
            Console.WriteLine($"Pago: {detallePago}");
            Console.WriteLine("Gracias por su compra.");
        }
    }
}
