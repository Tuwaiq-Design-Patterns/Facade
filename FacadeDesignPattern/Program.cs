using System;

namespace FacadeDesignPattern
{
    public class CarFacade 
    {
        protected CreateBody _createBody;

        protected CreateEngine _createEngine;

        public CarFacade(CreateBody createBody, CreateEngine createEngine)
        {
            this._createBody = createBody;
            this._createEngine = createEngine;
        }

        public string Operation()
        {
            string result = "  CarFacade :\n";
            result += this._createBody.operation1();
            result += this._createEngine.operation1();
      
            return result;
        }
    }
    public class CreateBody
    {
        public string operation1()
        {
            return "CreateBody: Body is created!\n";
        }

    }
    public class CreateEngine
    {
        public string operation1()
        {
            return "CreateEngine: Engine is created !\n";
        }

    }

    class Client
    {
        public static void ClientCode(CarFacade facade)
        {
            Console.Write(facade.Operation());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CreateBody createBody = new CreateBody();
            CreateEngine createEngine= new CreateEngine();
            CarFacade facade = new CarFacade(createBody, createEngine);
            Client.ClientCode(facade);
        }
    }                                                                                           
}
       
