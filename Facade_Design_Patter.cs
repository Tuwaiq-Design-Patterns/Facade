using System;

namespace Facade_Design_Patter
{

     class Product
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching the Product Details");
        }
    }

     class Payment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment Done");
        }
    }
     class Invoice
    {
        public void Sendinvoice()
        {
            Console.WriteLine("Invoice Send");
        }
    }

    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");
            Product product = new Product();
            product.GetDetails();
            Payment payment = new Payment();
            payment.MakePayment();
            Invoice invoice = new Invoice();
            invoice.Sendinvoice();
            Console.WriteLine("Order Placed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Order o = new Order();
            o.PlaceOrder();
        }
    }
}
