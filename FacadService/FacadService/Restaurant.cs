using System;

namespace FacadService
{
   
    
    class DishFoodItem { public int DishID; }

    
    interface IKitchen
    {
        DishFoodItem PrepDish(int DishID);
    }

    
    class Order
    {
        public DishFoodItem Appetizer { get; set; }
        public DishFoodItem Entree { get; set; }
        public DishFoodItem Drink { get; set; }
    }

    
    class Client
    {
        private string _name;

        public Client(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }


    
    class ColdPrep : IKitchen
    {
        public DishFoodItem PrepDish(int dishID)
        {
            Console.WriteLine("Cold Prep is preparing Appetizer #" + dishID);
            //Go prep the appetizer
            return new DishFoodItem()
            {
                DishID = dishID
            };
        }
    }

   
    class HotPrep : IKitchen
    {
        public DishFoodItem PrepDish(int dishID)
        {
            Console.WriteLine("Hot Prep is preparing Entree #" + dishID);
            //Go prep the entree
            return new DishFoodItem()
            {
                DishID = dishID
            };
        }
    }

   
    class Bar : IKitchen
    {
        public DishFoodItem PrepDish(int dishID)
        {
            Console.WriteLine("The Bar is preparing Drink #" + dishID);
            //Go mix the drink
            return new DishFoodItem()
            {
                DishID = dishID
            };
        }
    }

    
    class Server
    {
        private ColdPrep _coldPrep = new ColdPrep();
        private Bar _bar = new Bar();
        private HotPrep _hotPrep = new HotPrep();

        public Order PlaceOrder(Client client, int coldAppID, int hotEntreeID, int drinkID)
        {
            Console.WriteLine("{0} places order for cold app #" + coldAppID.ToString()
                                + ", hot entree #" + hotEntreeID.ToString()
                                + ", and drink #" + drinkID.ToString() + ".", client.Name);

            Order order = new Order();

            order.Appetizer = _coldPrep.PrepDish(coldAppID);
            order.Entree = _hotPrep.PrepDish(hotEntreeID);
            order.Drink = _bar.PrepDish(drinkID);

            return order;
        }
    }
}