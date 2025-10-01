using System;

namespace Lab8_6
{
    class ClaseBase
    {
        public virtual void masTests() { Console.WriteLine("Base.masTests"); }
    }

    class ClaseHijo : ClaseBase
    {
        public sealed override void masTests() { Console.WriteLine("Hijo.masTests (final)"); }
    }

    // La siguiente clase no puede sobrescribir masTests porque está sellado en ClaseHijo:
    // class ClaseNieto : ClaseHijo
    // {
    //     public override void masTests() { } // ERROR: cannot override sealed member
    // }

    internal class Program
    {
        private static void Main(string[] args)
        {
            ClaseBase b = new ClaseBase();
            b.masTests();
            ClaseHijo h = new ClaseHijo();
            h.masTests();
        }
    }
}
