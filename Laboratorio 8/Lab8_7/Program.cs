using System;

namespace Lab8_7
{
    sealed class ClaseBase
    {
        public void test() { Console.WriteLine("ClaseBase.test"); }
        public void moreTesting() { Console.WriteLine("ClaseBase.moreTesting"); }
    }

    // La siguiente declaración generaría error de compilación porque ClaseBase es sealed:
    // class ClaseHijo : ClaseBase { }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Corrió la aplicación");
            var b = new ClaseBase();
            b.test();
            b.moreTesting();
        }
    }
}
