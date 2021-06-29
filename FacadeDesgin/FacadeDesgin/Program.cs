using System;

namespace FacadeDesgin
{
    public class Facade
    {
        protected Cirecle _Cirecle;

        protected Square _Square;

        public Facade(Cirecle Cirecle, Square Square)
        {
            this._Cirecle = Cirecle;
            this._Square = Square;
        }

      
        public string Operation()
        {
            string result = "Drawing subsystems:\n";
            result += this._Cirecle.drawCirecle();
            result += this._Square.drawSquare();
            result += "Drawing subsystems 2:\n";
            result += this._Cirecle.operationN();
            result += this._Square.operationZ();
            return result;
        }
    }

    
    public class Cirecle
    {
        public string drawCirecle()
        {
            return "Cirecle!\n";
        }

        public string operationN()
        {
            return "Half Cirecle!\n";
        }
    }

    public class Square
    {
        public string drawSquare()
        {
            return "Square!\n";
        }

        public string operationZ()
        {
            return "Half Square!\n";
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
           
            Cirecle Cirecle = new Cirecle();
            Square Square = new Square();
            Facade facade = new Facade(Cirecle, Square);
            Client.ClientCode(facade);
        }
    }
}