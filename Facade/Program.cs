using System;

namespace Facade
{

    public class Order
    {
        protected Product _product;
        protected Invoice _invoice;
        protected Payment _payment;

        public Order(Product product, Invoice invoice, Payment payment)
        {
            _product = product;
            _invoice = invoice;
            _payment = payment;
        }

        public string PlaceOrder()
        {
            string result = "your cart has been initialized:\n";
            result += this._product.GetIphone();
            result += this._product.GetCatFood();
            result += this._product.GetMug();
            result += "Your Items total:\n";
            result += this._invoice.GetTotal();
            result += this._payment.ProcessPayment();
            return result;
        }
        
    }

    public class Product
    {
        public string GetIphone()
        {
            return "iPhone 12   256GB       space gray      100$\n";
        }

        public string GetCatFood()
        {
                return "FancyF      Wet food    85g         25$\n";
        }

        public string GetMug()
        {
            return "Mug         blue        200ml       15$";
        }
    }

    public class Invoice
    {
        public string GetTotal()
        {
            return "Total:      140$        tax included\n";
        }
    }

    public class Payment
    {
        public string ProcessPayment()
        {
            return "Payment method: Apple pay\n";
        }
    }

    class Client
    {
        public static void PlaceOrder(Order order)
        {
            Console.WriteLine(order.PlaceOrder());
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Product productsys = new Product();
            Invoice invoicesys = new Invoice();
            Payment paymentsys = new Payment();
            Order order = new Order(productsys, invoicesys, paymentsys);
            Client.PlaceOrder(order);
        }
    }
}