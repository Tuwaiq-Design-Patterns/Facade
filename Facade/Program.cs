using System;

namespace Facade
{
   
        public class Program
        {
            public static void Main(string[] args)
            {
                var facadeForClient = new BankFacade();
                Console.WriteLine("Client Wants services via bank \n");
                facadeForClient.TransferMoney();
                facadeForClient.DepositMoney();
             
            }
        }
        public class BankFacade
        {
            private Services _Services;
      
            public BankFacade()
            {
                _Services = new Services();
               
            }
            public void TransferMoney()
            {
                _Services.TransferMoney();
            }
            public void DepositMoney()
            {
                _Services.DepositMoney();
            }
         
        }
    
        public class Services 
        {
            public void TransferMoney()
            {
                Console.WriteLine("Money Transfered");
            }
            public void DepositMoney()
            {
                Console.WriteLine("Money Deposited");
            }

        }
       
       
}

