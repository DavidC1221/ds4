using System;

namespace Lab8_4
{
    // Propiedades de lectura/escritura
    public class Empleado
    {
        private string nombre = string.Empty;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }

    // Propiedades con validación
    public class CuentaBancaria
    {
        private decimal saldo;
        public decimal Saldo
        {
            get { return saldo; }
            set
            {
                if (value >= 0) saldo = value;
                else throw new ArgumentException("El saldo no puede ser negativo.");
            }
        }
    }

    // Propiedad de solo lectura
    public class Cobertura
    {
        private double radio;
        public Cobertura(double radio) { this.radio = radio; }
        public double Radio { get { return radio; } }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = "John Doe";
            Console.WriteLine($"Nombre del empleado: {empleado.Nombre}");

            CuentaBancaria cta = new CuentaBancaria();
            cta.Saldo = 100;
            Console.WriteLine($"EL saldo del empleado: {cta.Saldo}");
            // Probar con un saldo negativo descomente la línea siguiente para ver la excepción
            // cta.Saldo = -10;

            Cobertura c = new Cobertura(5);
            Console.WriteLine($"Con una cobertura de: {c.Radio}");
        }
    }
}
