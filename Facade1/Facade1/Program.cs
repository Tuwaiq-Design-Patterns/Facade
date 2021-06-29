using System;

namespace Facade
{

    public class Facade
    {
        protected Resturent _resturent;


        public Facade(Resturent resturent)
        {
            this._resturent = resturent;
        }

        public string Order()
        {
            string result = "Customer Order:\n";
            result += this._resturent.Delevery();
 
            return result;
        }
    }

    public class Resturent
    {
        public string Delevery()
        {
            return "Delevery: Done!\n";
        }

    }


    class Client
    {

        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Order());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Resturent resturent = new Resturent();
            Facade facade = new Facade(resturent);
            Client.ClientCode(facade);
        }
    }
}