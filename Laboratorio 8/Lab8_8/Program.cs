using System;

namespace Lab8_8
{
    abstract class ClaseAbstracta
    {
        // Se fuerza a las clases hijas implementar estos métodos
        protected abstract string tomarValor();
        public abstract string prefijarValor(string prefix);

        public void printOut()
        {
            Console.WriteLine(tomarValor());
        }
    }

    class ClaseConcreta1 : ClaseAbstracta
    {
        protected override string tomarValor() => "ClaseConcreta1";
        public override string prefijarValor(string prefix) => $"{prefix}ClaseConcreta1";
    }

    class ClaseConcreta2 : ClaseAbstracta
    {
        protected override string tomarValor() => "ClaseConcreta2";
        public override string prefijarValor(string prefix) => $"{prefix}ClaseConcreta2";
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            ClaseConcreta1 concreta1 = new ClaseConcreta1();
            concreta1.printOut();
            Console.WriteLine(concreta1.prefijarValor("ES-"));

            ClaseConcreta2 concreta2 = new ClaseConcreta2();
            concreta2.printOut();
            Console.WriteLine(concreta2.prefijarValor("ES-"));
        }
    }
}
