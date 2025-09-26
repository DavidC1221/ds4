using System;
using System.Collections.Generic;
// Lab 5-4: promedio con List<int>
class Program
{
    static void Main(string[] args)
    {
        List<int> calificaciones = new() { 85, 90, 78, 92, 88 };
        int suma = 0;
        foreach (int cal in calificaciones)
        {
            suma += cal;
        }
        double promedio = suma / (double)calificaciones.Count;
        Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
    }
}
