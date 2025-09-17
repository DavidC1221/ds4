using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo utilizando las variables de instancia de Clase
            Client client = new Client();
            client.FirstName = "David";
            client.LastName = "Cordoba";
            client.Age = 20;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());
        }
    }

    public class Client
    {
        // Declarando variables de instancia en clase
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }

        public string GetFullName()
        {
            // Utilizando variables de instancia dentro de métodos de la clase
            return FirstName + " " + LastName;
        }
    }
}
