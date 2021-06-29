using static System.Console;
namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new RestaurantFacade();
            WriteLine("----------------------CLIENT ORDERS FROM DOMINOSPIZZA----------------------------\n");
            facade.GetPhillySteakPizza();
            facade.GetChickenLegendPizza();
            WriteLine("----------------------CLIENT ORDERS FROM MCDONALDS----------------------------\n");
            facade.GetBigTastyBurger();
            facade.GetMcChickenBurger();
        }
    }
}
