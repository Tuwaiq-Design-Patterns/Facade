using System;

namespace Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.Deposit();
            facade.withdraw();
      
        }
    }

    public class Deposite
    {
        public void subscribe()
        {
            Console.WriteLine(" Deposite Method");
        }
    }

    public class Withdraw
    {
        public void addition()
        {
            Console.WriteLine(" Withdraw Method");
        }
    }
  
 

    public class Facade
    {
        Deposite Deposites;
        Withdraw withdraws;
  
        public Facade()
        {
           
            withdraws = new Withdraw();
            Deposites = new Deposite();

        }
        public void Deposit()
        {
            Console.WriteLine("\n Deposit from bank account");
            Deposites.subscribe();


        }
        public void withdraw()
        {
            Console.WriteLine("\nwithdraw from bank account");
            withdraws.addition();
          
        }
    }
}


