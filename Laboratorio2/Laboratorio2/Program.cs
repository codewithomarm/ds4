﻿internal class Program
{
    private static void Main(string[] args)
    {
        Client client = new Client();
        // Ejemplo utilizando las variables de instancia de Clase.
        client.FirstName = "Omar";
        client.LastName = "Montoya";
        client.Age = 28;
        client.Id = 1;

        Console.WriteLine(client.GetFullName());
    }

    public class Client
    {
        // Declarando variables de instancia en clase.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }

        public string GetFullName()
        {
            // Utilizando variables de instancia dentro de metodos de la clase.
            return FirstName + " " + LastName;
        }
    }
}