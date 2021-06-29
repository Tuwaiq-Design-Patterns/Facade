using System;

namespace Facade_DP
{
    class Program
    {
        protected class Pizza
        {
            public decimal VegiPizzaPrice = 20;
            public decimal NonVegiPizzaPrice = 25;
            public void GetVegeterianPizza() { Console.WriteLine("\nGetting Vegeterian Pizza..."); }
            public void GetNonVegeterianPizza() { Console.WriteLine("\nGetting Non Vegeterian Pizza..."); }
            
        }

        protected class Toppings
        {
            public decimal chickenPrice = 8;
            public decimal meatPrice = 9;
            public decimal mashroomPrice = 5;
            public decimal spanichPrice = 6;
            public decimal onionsPrice = 3;
            public void GetCheckinTopping() { Console.WriteLine("\nAdding Checkin Topping..."); }
            public void GetMeatTopping() { Console.WriteLine("\nAdding Meat Topping..."); }
            public void GetMashroomTopping() { Console.WriteLine("\nAdding Mashroom Topping..."); }
            public void GetSpanichTopping() { Console.WriteLine("\nAdding Spanich Topping..."); }
            public void GetOnionsTopping() { Console.WriteLine("\nAdding Onions Topping..."); }
        }

        public class RestaurantFacade
        {
            private Pizza _pizza = new Pizza();
            private Toppings _toppings = new Toppings();

            public decimal Total = 0;

            public void GetCustomerOrder()
            {
                Console.WriteLine("\tWelcome To Pizzaria.");
                
                Console.WriteLine(" \n\t choose your Pizza: \n\t 1. Vegeterian Pizza \n\t 2. Non-Vegeterian Pizza");
                int customerPizzaChoice = Convert.ToInt32(Console.ReadLine());

                int customerToppingChoice = 0;
                string customerContinue = "";


                if (customerPizzaChoice == 1)
                {
                    _pizza.GetVegeterianPizza();

                    do
                    {
                        Console.WriteLine("\n\t Choose Your Toppings" +
                        "\n\t1. Mashroom \n\t2. Spanich \n\t3. Onions");

                        customerToppingChoice = Convert.ToInt32(Console.ReadLine());

                        ProcessVegeterianPizza(customerToppingChoice);

                        Console.WriteLine("\n\t Any Other Topping? (yes/no)");
                        customerContinue = Console.ReadLine();
                    } while (customerContinue == "yes") ;


                    Total += _pizza.VegiPizzaPrice;
                    Console.WriteLine("Your Total is: $ " + Total);

                }

                else if (customerPizzaChoice == 2)
                {
                    _pizza.GetNonVegeterianPizza();

                    do
                    {
                        Console.WriteLine("\n\t Choose Your Toppings" +
                        "\n\t1. Meat \n\t2. Chicken \n\t3. Mashroom \n\t4. Spanich \n\t5. Onions");

                        customerToppingChoice = Convert.ToInt32(Console.ReadLine());

                        ProcessNonVegeterianPizza(customerToppingChoice);

                        Console.WriteLine("\n\t Any Other Topping? (yes/no)");
                        customerContinue = Console.ReadLine();
                    } while (customerContinue == "yes");

                    Total += _pizza.NonVegiPizzaPrice;
                    Console.WriteLine("Your Total is: $ "+ Total);
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                }
            }

            public decimal ProcessVegeterianPizza(int toppingNumber)
            {
                if (toppingNumber == 1)
                {
                    _toppings.GetMashroomTopping();
                    return Total += _toppings.mashroomPrice;
                }
                else if (toppingNumber == 2)
                {
                    _toppings.GetSpanichTopping();
                    return Total += _toppings.spanichPrice;
                }
                else if (toppingNumber == 3)
                {
                    _toppings.GetOnionsTopping();
                    return Total += _toppings.onionsPrice;
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                    return Total += 0;
                }
            }

            public decimal ProcessNonVegeterianPizza(int toppingNumber)
            {
                if (toppingNumber == 1)
                {
                    _toppings.GetMeatTopping();
                    return Total += _toppings.meatPrice;
                }
                else if (toppingNumber == 2)
                {
                    _toppings.GetCheckinTopping();
                    return Total += _toppings.chickenPrice;
                }
                else if (toppingNumber == 3)
                {
                    _toppings.GetMashroomTopping();
                    return Total += _toppings.mashroomPrice;
                }
                else if (toppingNumber == 4)
                {
                    _toppings.GetSpanichTopping();
                    return Total += _toppings.spanichPrice;
                }
                else if (toppingNumber == 5)
                {
                    _toppings.GetOnionsTopping();
                    return Total += _toppings.onionsPrice;
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                    return Total += 0;
                }
            }          
        }

        

       static void Main(string[] args)
        {
            RestaurantFacade restaurant = new RestaurantFacade();
            restaurant.GetCustomerOrder();
            Console.ReadKey();
        }
    }
}
