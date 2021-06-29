using System;

namespace FacadePractice
{

    public class WashingMachine
    {
        protected Rinse _rinse;
        protected Wash _wash;
        protected Dry _dry;

        public WashingMachine(Rinse rinse, Wash wash, Dry dry)
        {
            this._rinse = rinse;
            this._wash = wash;
            this._dry = dry;
        }


        public string Operation()
        {
            string result = "Washing Machine getting ready:\n";
            result += this._rinse.CalculateWeight();
            result += this._wash.AddWaterAndDetergent();
            result += "Washing Machine starting:\n";
            result += this._rinse.rinse();
            result += this._wash.wash();
            result += "Washing Machine drying clothes:\n";
            result += this._dry.dry();
            return result;
        }
    }


    public class Rinse
    {
        public string CalculateWeight()
        {
            return "Clothes Weight calcualted!\n"; // maybe so that it's save to start :) 
        }

        public string rinse()
        {
            return "Rinsing...\n";
        }
    }

    public class Wash
    {
        public string AddWaterAndDetergent()
        {
            return "Adding water and detergent...\n";
        }

        public string wash()
        {
            return "washing...\n";
        }
    }

    public class Dry
    {
        public string dry()
        {
            return "clothes are dry! :)\n";
        }
    }


    class Client
    {
        public static void ClientCode(WashingMachine wm)
        {
            Console.Write(wm.Operation());
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Rinse rinse = new Rinse();
            Wash wash = new Wash();
            Dry dry = new Dry();
            WashingMachine wm = new WashingMachine(rinse, wash, dry);
            Client.ClientCode(wm);
        }
    }
}
