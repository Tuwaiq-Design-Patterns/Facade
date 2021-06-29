using System;
using System.Xml;

namespace ConsoleApp4
{
    public class Facade
    {
        protected Fries fries;
        
        protected Burger burger;

        public Facade(Fries fires, Burger burger)
        {
            this.fries = fires;
            this.burger = burger;
        }
        public string OrderMeal()
        {
            string result = "getting the fries:\n";
            result += this.fries.cookingfries();
            result += this.fries.friesready();
            result += "getting the burger:\n";
            result += this.burger.cookingBurger();
            result += this.burger.burgerReady();
            return result;
        }
    }
    

    public class Fries
    {
        public string cookingfries()
        {
            return "cooking the fries\n";
        }

        public string friesready()
        {
            return "fries are: Ready!\n";
        }
    }
    
    public class Burger
    {
        public string cookingBurger()
        {
            return "cooking the Burger!\n";
        }

        public string burgerReady()
        {
            return "Burger are: Ready!\n";
        }
    }
    class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.OrderMeal());
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Burger subsystem1 = new Burger();
            Fries subsystem2 = new Fries();
            Facade facade = new Facade(subsystem2, subsystem1);
            Client.ClientCode(facade);
        }
    }
}