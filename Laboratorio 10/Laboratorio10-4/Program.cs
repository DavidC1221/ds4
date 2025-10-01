using System;

namespace Laboratorio10_4
{
    public class Perro
    {
        public string nombre { get; set; }
        public string raza { get; set; }
        public string altura { get; set; }

        public string Comer(string carne)
        {
            return nombre + " mide " + altura + " y comerá " + carne;
        }

        public double CalcularCosto(double costo, double impuesto)
        {
            return costo + (costo * impuesto);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Perro perrito1 = new Perro() { nombre = "Chizu", raza = "Pastor Alemán", altura = "0.70cm" };
            Console.WriteLine(perrito1.Comer("Carne"));

            Perro perrito2 = new Perro() { nombre = "Lasy", raza = "Beagle", altura = "0.60cm" };
            Console.WriteLine(perrito2.Comer("Pollo"));

            Perro perrito3 = new Perro() { nombre = "Peluchín", raza = "Poodle", altura = "0.50cm" };
            Console.WriteLine(perrito3.Comer("Pan"));
        }
    }
}