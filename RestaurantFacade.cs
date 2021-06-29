namespace Facade
{
    public class RestaurantFacade
    {
        private IDominosPizza _DominosProvider;
        private IMcDonalds _McDonaldsProvider;
        public RestaurantFacade()
        {
            _DominosProvider = new DominosPizzaProvider();
            _McDonaldsProvider = new McDonaldsProvider();
        }

        public void GetChickenLegendPizza()
        {
            _DominosProvider.GetChickenLegendPizza();
        }
        public void GetPhillySteakPizza()
        {
            _DominosProvider.GetPhillySteakPizza();
        }

        public void GetBigTastyBurger()
        {
            _McDonaldsProvider.GetBigTastyBurger();
        }
        public void GetMcChickenBurger()
        {
            _McDonaldsProvider.GetMcChickenBurger();
        }
    }
}