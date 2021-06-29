using System;

namespace facade_design_pattern
{
    public class Order
    {
        protected Product products;

        protected Payment payment;

        protected Invoice invoice;

        public Order(Product subsystem1, Payment subsystem2, Invoice subsystem3)
        {
            this.products = subsystem1;
            this.payment = subsystem2;
            this.invoice = subsystem3;
        }

        public string PlaceOrder()
        {
            string result = "Placing order:\n";
            result += this.products.getProductInfo();
            result += this.products.operationN();
            result += "Payment:\n";
            result += this.payment.paymentMethod();
            result += this.payment.paymentStatus();
            result += "Invoice:\n";
            result += this.invoice.invoiceDetails();
            return result;
        }
    }

    public class Product
    {
        public string getProductInfo()
        {
            return "Products :\n";
        }

        public string operationN()
        {
            return "1- pencil\t 2.00$\n2- notebook\t 2.89$\n";
        }
    }

    public class Payment
    {
        public string paymentMethod()
        {
            return "using Apple pay\n";
        }

        public string paymentStatus()
        {
            return "success!\n";
        }
    }

    public class Invoice
    {
        public string invoiceDetails()
        {
            return @"--------------------------
ORDER
--------------------------
Total:      4.89$";
        }
    }

    class Client
    {
        public static void ClientCode(Order facade)
        {
            Console.Write(facade.PlaceOrder());
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            Product subsystem1 = new Product();
            Payment subsystem2 = new Payment();
            Invoice subsystem3 = new Invoice();
            Order facade = new Order(subsystem1, subsystem2, subsystem3);
            Client.ClientCode(facade);
        }
    }
}