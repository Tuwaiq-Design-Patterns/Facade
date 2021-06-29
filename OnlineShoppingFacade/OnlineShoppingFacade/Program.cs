using System;

namespace OnlineShoppingFacade
{

    interface IInventory
    {
        void Update(int productId);
    }

    interface IOrderVerify
    {
        bool VerifyShippingAddress(int pincode);
    }

    class OrderVerificationManager : IOrderVerify
    {

        public bool VerifyShippingAddress(int pincode)
        {
            Console.WriteLine(string.Format("The product can be shipped to the pincode {0}.",pincode));
            return true;
        }
    }

    class OrderDetails
    {
        public int ProductNo { get; private set; }

        public string ProductName { get; private set; }
        public float Price { get; set; }
        public int PinCode { get; private set; }
        public string CardNo { get; private set; }

        public OrderDetails(int ProductNo, string productName, float price,
                            int pinCode, string cardNo)
        {
            this.ProductNo = ProductNo;
            this.ProductName = productName;
            this.Price = price;
            this.PinCode = pinCode;
            this.CardNo = cardNo;
        }

        interface IPaymentGateway
        {
            bool VerifyCardDetails(string cardNo);
            bool ProcessPayment(string cardNo, float cost);
        }


        class PaymentGatewayManager : IPaymentGateway
        {
            public bool VerifyCardDetails(string cardNo)
            {
                Console.WriteLine(string.Format("Card# {0} has been verified and is accepted.",
                                                 cardNo));
                return true;
            }

            public bool ProcessPayment(string cardNo, float cost)
            {
                Console.WriteLine(string.Format("Card# {0} is used to make a payment of {1}.", cardNo, cost));
                return true;
            }
        }
        class InventoryManager : IInventory
        {
            public void Update(int productId)
            {
                Console.WriteLine(string.Format("Product# {0} is subtracted from the store's inventory.", productId));
            }
        }
        class OnlineShoppingFacade
        {
            IInventory inventory = new InventoryManager();
            IOrderVerify orderVerify = new OrderVerificationManager();
            IPaymentGateway paymentGateWay = new PaymentGatewayManager();

            public void FinalizeOrder(OrderDetails orderDetails)
            {
                inventory.Update(orderDetails.ProductNo);
                orderVerify.VerifyShippingAddress(orderDetails.PinCode);
                paymentGateWay.VerifyCardDetails(orderDetails.CardNo);
                paymentGateWay.ProcessPayment(orderDetails.CardNo, orderDetails.Price);

            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                OrderDetails orderDetails = new OrderDetails(13,
                                                            "C# Design Patterns Book",
                                                             40,
                                                             59113,
                                                             "131313"
                                                             );

                OnlineShoppingFacade facade = new OnlineShoppingFacade();
                facade.FinalizeOrder(orderDetails);

                Console.ReadLine();

            }
        }
    }
}
