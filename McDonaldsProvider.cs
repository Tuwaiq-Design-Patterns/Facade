using static System.Console;
namespace Facade
{
    public class McDonaldsProvider : IMcDonalds
    {
        public void GetBigTastyBurger()
        {
            AddExtraSauce();
            WriteLine("Serving BigTasty Burger.");
        }
        public void GetMcChickenBurger()
        {
            WriteLine("Serving McChicken Burger.");
        }

        public void AddExtraSauce()
        {
            WriteLine("Adding extra sauce...");
        }
    }
}