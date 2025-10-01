using System;

namespace Lab8_9
{
    interface ITemplate
    {
        void ponerVariable(string nombre, string var);
        void writeIn(string template);
    }

    class Template : ITemplate
    {
        public void ponerVariable(string nombre, string var)
        {
            Console.WriteLine("Metodo poner variable {0}: {1}", nombre, var);
        }

        public void writeIn(string template)
        {
            Console.WriteLine(template);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Template temp1 = new Template();
            temp1.ponerVariable("var1", "Valor 1");
            temp1.ponerVariable("var2", "Valor 2");
            temp1.ponerVariable("var3", "Valor 3");
            temp1.writeIn("<b>Texto de Pruebas</b>");
        }
    }
}
