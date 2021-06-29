using System;

namespace FacadeDesignPattern
{
    public class DelievryService
    {
        PizzaResturant pizzaResturant;
        BurgerResturant burgerResturant;

       
        public DelievryService()
        {
            pizzaResturant = new PizzaResturant();
            burgerResturant = new BurgerResturant();
           
        }

        public void OrderOne()
        {
            Console.WriteLine("\nOrderOne --------------- ");
            pizzaResturant.mealOne();
            pizzaResturant.mealTwo();
            burgerResturant.mealtwo();
        }
        public void OrderTwo()
        {
            Console.WriteLine("\nOrderTwo --------------- ");
            burgerResturant.mealOne();
            burgerResturant.mealtwo();
        }
    }
    public class PizzaResturant
    {
        public void mealOne()
        {
            Console.WriteLine(" Alfrado pizza");
        }

        public void mealTwo()
        {
            Console.WriteLine(" Buffalo checkin pizza");
        }
    }

    public class BurgerResturant
    {
        public void mealOne()
        {
            Console.WriteLine(" Beef burger");
        }
        public void mealtwo()
        {
            Console.WriteLine(" Checkin burger");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            DelievryService delievryService = new DelievryService();
            delievryService.OrderOne();
            delievryService.OrderTwo();
        }
    }
}
