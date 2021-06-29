using System;

namespace FacadeDesignPattren
{ class SubSystemA
    {
           
        public void ValidateUser(string userName, string password)

        {

            Console.WriteLine("Validate user credentials...");

        }

    }
    class SubSystemB
    {
        public void ValidateCreditCard(string cardNumber)

        {

            Console.WriteLine("Validate credit card...");

        }

        public void PayAmount(string cardNumber, double amount)

        {

            Console.WriteLine("Pay amount...");

        }
    }
    class Facade
    {
        SubSystemA firstSubsystem = new SubSystemA();

        SubSystemB secondSubsystem = new SubSystemB();

        public void Operation1(string userName, string password)

        {

            firstSubsystem.ValidateUser(userName, password);

        }

        public void Operation2(string cardNumber, double amount)

        {

            secondSubsystem.ValidateCreditCard("1234567890");

            secondSubsystem.PayAmount(cardNumber, amount);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.Operation1("shahad", "shahad123");

            facade.Operation2("1234567890", 100.00);

            Console.Read();
        }
    }
}
