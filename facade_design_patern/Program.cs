using System;

namespace facade_design_patern
{

    public class Program
    {
        public static void Main(string[] args)
        {
            var facadeForClient = new RestaurantFacade();

            Console.WriteLine("___CLIENT ORDERS FOR Tea___\n");
            facadeForClient.GetGreenTea();
            facadeForClient.GetRedTea();

            Console.WriteLine("\n---CLIENT ORDERS FOR BREAD-------\n");
            facadeForClient.GetGarlicBread();
            facadeForClient.GetCheesyGarlicBread();
        }
    }

    public class RestaurantFacade
    {
        private TeaProvider _TeaProvider;
        private BreadProvider _BreadProvider;

        public RestaurantFacade()
        {
            _TeaProvider = new TeaProvider();
            _BreadProvider = new BreadProvider();
        }
        public void GetGreenTea()
        {
            _TeaProvider.GetGreenTea();
        }
        public void GetRedTea()
        {
            _TeaProvider.GetRedTea();
        }
        public void GetGarlicBread()
        {
            _BreadProvider.GetGarlicBread();
        }
        public void GetCheesyGarlicBread()
        {
            _BreadProvider.GetCheesyGarlicBread();
        }
    }

    public class TeaProvider
    {
        public void GetGreenTea()
        {
            Console.WriteLine("Getting Green Tea.");
        }
        public void GetRedTea()
        {
            Console.WriteLine("Getting Red Tea.");
        }
    }



    public class BreadProvider 
    {
        public void GetGarlicBread()
        {
            Console.WriteLine("Getting Garlic Bread.");
        }
        public void GetCheesyGarlicBread()
        {
            GetCheese();
            Console.WriteLine("Getting Cheesy Garlic Bread.");
        }
        private void GetCheese()
        {
            Console.WriteLine("Getting Cheese.");
        }
    }
}
