using System;

namespace FacadeDesignPattren
{

    public class Product
    {
        public void GetProductDetails()
        {
            Console.WriteLine("Product Details:");
            Console.WriteLine("Name: Iphone 12 white 128GB ");
            Console.WriteLine("Price: 3050 SAR");

        }
    }

    public class Payment
    {
        public void MakePayment()
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Payment done successfully");
            Console.WriteLine("------------------------------");

        }
    }

    public class Invoice
    {
        public void Sendinvoice()
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Invoice send successfully");
            Console.WriteLine("------------------------------");

        }

        public class Order
        {
            public void PlaceOrder()
            {
                Console.WriteLine("Norah, place a new order: ");
                Console.WriteLine("------------------------------\n");

                Product product = new Product();
                product.GetProductDetails();

                Payment payment = new Payment();
                payment.MakePayment();

                Invoice invoice = new Invoice();
                invoice.Sendinvoice();

                Console.WriteLine("\n------------------------------");
                Console.WriteLine("Order placed successfully ^-^ ");
                Console.WriteLine("------------------------------");

            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Order order = new Order();

                order.PlaceOrder();
            }
        }
    }
}
