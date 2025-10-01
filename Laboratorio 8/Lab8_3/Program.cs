using System;

namespace Lab8_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Suma(3, 5));          // int
            Console.WriteLine(Suma(1.0, 2.2));      // double
            Console.WriteLine(Suma(100L, 250L));    // long
        }

        static int Suma(int x, int y) => x + y;
        static double Suma(double x, double y) => x + y;
        static long Suma(long x, long y) => x + y;
    }
}
