using static System.Console;
namespace Facade
{
    public class DominosPizzaProvider : IDominosPizza
    {
        public void GetChickenLegendPizza()
        {
            WriteLine("Serving ChickenLegend Pizza.");
        }
        public void GetPhillySteakPizza()
        {
            AddExtraCheese();
            WriteLine("Serving PhillySteak Pizza.");
        }

        public void AddExtraCheese()
        {
            WriteLine("Adding extra cheese...");
        }
    }
}