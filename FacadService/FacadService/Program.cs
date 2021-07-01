using System;

namespace FacadService
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();

            Console.WriteLine("Hello!  I'll be your server today. What is your name?");
            var name = Console.ReadLine();

            Client client = new Client(name); 

            Console.WriteLine("Hello " + client.Name + ". What appetizer would you like? (1-15):");
            var appID = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("That's a good one.  What entree would you like? (1-20):");
            var entreeID = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("A great choice!  Finally, what drink would you like? (1-60):");
            var drinkID = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("I'll get that order in right away.");

            server.PlaceOrder(client, appID, entreeID, drinkID);

            Console.ReadKey();
        }
    }
}