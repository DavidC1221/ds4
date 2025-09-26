using System;
// Lab 5-3: foreach sobre arreglo de frutas
class Program
{
    static void Main(string[] args)
    {
        string[] frutas = { "manzana", "plátano", "naranja", "pera", "uva" };
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }
    }
}
