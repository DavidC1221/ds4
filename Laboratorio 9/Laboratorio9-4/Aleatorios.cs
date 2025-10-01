using System;
using System.Collections.Generic;

namespace Laboratorio94
{
    public class Aleatorios
    {
        private readonly Random rnd;

        public Aleatorios() : this(null) { }
        public Aleatorios(int? seed)
        {
            rnd = seed.HasValue ? new Random(seed.Value) : new Random();
        }

        public int GenerarNumero(int min, int max)
        {
            if (min > max) (min, max) = (max, min);
            return rnd.Next(min, max + 1);
        }

        public int[] GenerarArreglo(int min, int max, int cantidad)
        {
            if (min > max) (min, max) = (max, min);
            if (cantidad <= 0) return Array.Empty<int>();
            var datos = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
                datos[i] = GenerarNumero(min, max);
            return datos;
        }

        public int[] GenerarArregloNoRepetidos(int min, int max, int cantidad)
        {
            if (min > max) (min, max) = (max, min);
            int rango = max - min + 1;
            if (cantidad > rango) throw new ArgumentException("Cantidad mayor que el rango disponible sin repetidos.");
            var set = new HashSet<int>();
            while (set.Count < cantidad) set.Add(GenerarNumero(min, max));
            var arr = new int[cantidad];
            set.CopyTo(arr);
            return arr;
        }
    }
}
