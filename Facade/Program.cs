using System;

namespace Facade
{
    // The Facade class provides a simple interface to the complex logic of one
    // or several subsystems. The Facade delegates the client requests to the
    // appropriate objects within the subsystem. The Facade is also responsible
    // for managing their lifecycle. All of this shields the client from the
    // undesired complexity of the subsystem.
    public class Order
    {
        protected Product _Product;

        protected Invoice _Invoice;
        protected Payment _Paynment;

        public Order(Product prod, Invoice inv, Payment pay)
        {
            this._Product = prod;
            this._Invoice = inv;
            this._Paynment = pay;
        }

        // The Facade's methods are convenient shortcuts to the sophisticated
        // functionality of the subsystems. However, clients get only to a
        // fraction of a subsystem's capabilities.
        public string PlaceOrder()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._Product.getProudcts();
            result += this._Paynment.Pay();
            result += this._Invoice.GetInvoice();
            return result;
        }
    }

    // The Subsystem can accept requests either from the facade or client
    // directly. In any case, to the Subsystem, the Facade is yet another
    // client, and it's not a part of the Subsystem.
    public class Product
    {
        public string getProudcts()
        {
            return "iPhone 12\t\t554$\t\tBlack\nTV\t\t\t299$\t\tHP\n\n";
        }

    }
        
    public class Payment
    {
        public string Pay()
        {
            return "International Purchase\nCard:\t\t***247; ApplePay\nAmount:\t\tUSD 853\n\n";
        }

    }

    // Some facades can work with multiple subsystems at the same time.
    public class Invoice
    {
        public string GetInvoice()
        {
            return "ORDER:\niPhone 12\t554$\nTV\t\t299$\ntotal:\t\t853$";
        }

    }


    class Client
    {
        // The client code works with complex subsystems through a simple
        // interface provided by the Facade. When a facade manages the lifecycle
        // of the subsystem, the client might not even know about the existence
        // of the subsystem. This approach lets you keep the complexity under
        // control.
        public static void ClientCode(Order order)
        {
            Console.Write(order.PlaceOrder());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The client code may have some of the subsystem's objects already
            // created. In this case, it might be worthwhile to initialize the
            // Facade with these objects instead of letting the Facade create
            // new instances.
            Product prod = new Product();
            Payment pay = new Payment();
            Invoice inv = new Invoice();
            Order order = new Order(prod,inv, pay);
            Client.ClientCode(order);
        }
    }
}
