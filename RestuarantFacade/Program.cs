using System;

namespace RestuarantFacade
{
    
    public class Facade
    {
        protected Burger _burger;
        protected Fries _fries;

        public Facade(Burger burger, Fries fries)
        {
            this._burger = burger;
            this._fries = fries;
        }

        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._burger.startBurger();
            result += this._fries.startFrying();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._burger.finishBurger();
            result += this._fries.finishFrying();
            return result;
        }
    }

    public class Burger
    {
        public string startBurger()
        {
            return "Burger: Started making a burger!\n";
        }

        public string finishBurger()
        {
            return "Burger: Burger ready!\n";
        }
    }

    public class Fries
    {
        public string startFrying()
        {
            return "Fries: Started frying some potatoes!\n";
        }

        public string finishFrying()
        {
            return "Fries: Fries Ready!\n";
        }
    }


    class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Burger burger = new Burger();
            Fries fries = new Fries();
            Facade facade = new Facade(burger, fries);
            Client.ClientCode(facade);
        }
    }
}