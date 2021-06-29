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
        public void addition()
        {
            Console.WriteLine(" Deposite Method");
        }
    }

    public class Withdraw
    {
        public void subscribe()
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
            Deposites.addition();


        }
        public void withdraw()
        {
            Console.WriteLine("\nwithdraw from bank account");
            withdraws.subscribe();
          
          
        }
    }
}


