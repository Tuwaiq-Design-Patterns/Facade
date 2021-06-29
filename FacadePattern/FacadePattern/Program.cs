using System;

namespace FacadePattern
{
    public interface IBurger
    {
        void GetVegBurger();
        void GetNonVegBurger();
    }
    public interface IBread
    {
        void GetWhiteBread();
        void GetWheatBread();
    }
    public class BurgerProvider : IBurger
    {
        public void GetNonVegBurger()
        {
            GetNonVegToppings();
            Console.WriteLine("Getting Non Veg Burger.");
        }
        public void GetVegBurger()
        {
            Console.WriteLine("Getting Veg Burger.");
        }
        private void GetNonVegToppings()
        {
            Console.WriteLine("Getting Non Veg Burger Toppings.");
        }
    }
    public class BreadProvider : IBread
    {
        public void GetWhiteBread()
        {
            Console.WriteLine("Getting White Bread.");
        }
        public void GetWheatBread()
        {
            Console.WriteLine("Getting Wheat Bread.");
        }
    }
    public class RestaurantFacade
    {
        private IBurger _BurgerProvider;
        private IBread _BreadProvider;
        public RestaurantFacade()
        {
            _BurgerProvider = new BurgerProvider();
            _BreadProvider = new BreadProvider();
        }
        public void GetNonVegBurger()
        {
            _BurgerProvider.GetNonVegBurger();
        }
        public void GetVegBurger()
        {
            _BurgerProvider.GetVegBurger();
        }
        public void GetWhiteBread()
        {
            _BreadProvider.GetWhiteBread();
        }
        public void GetWheatBread()
        {
            _BreadProvider.GetWheatBread();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------CLIENT ORDERS FOR BURGER----------------------------\n");
            var facadeForClient = new RestaurantFacade();
            facadeForClient.GetNonVegBurger();
            facadeForClient.GetVegBurger();
            Console.WriteLine("\n----------------------CLIENT ORDERS FOR BREAD----------------------------\n");
            facadeForClient.GetWhiteBread();
            facadeForClient.GetWheatBread();

            Console.ReadKey();
        }
    }
}
