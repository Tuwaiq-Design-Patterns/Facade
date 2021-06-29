using System;

namespace Facade
{

    public class FlatWhiteOrder
    {
        public void GetCoffeeDetails()
        {
            Console.WriteLine("Flat White small size with extra shot espresso ");
        }
    }
    public class Payment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment Done Successfully");
        }
    }

    public class Invoice
    {
        public void Sendinvoice()
        {
            Console.WriteLine("Invoice Send Successfully");
        }
    }

    public class Order
    {
        public void OrderStarted()
        {
            Console.WriteLine("Order Started");
            FlatWhiteOrder product = new FlatWhiteOrder();
            product.GetCoffeeDetails();
            Payment payment = new Payment();
            payment.MakePayment();
            Invoice invoice = new Invoice();
            invoice.Sendinvoice();
            Console.WriteLine("Order done Successfully");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
         
                Order order = new Order();
                order.OrderStarted();
            
        }
    }
}
