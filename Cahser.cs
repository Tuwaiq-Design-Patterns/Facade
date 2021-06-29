using System;
namespace facade{

public class Casher{
     
    public void ClientOrder(){
        Console.WriteLine("\n Cashier\n");
        Console.WriteLine("All good Mr/Ms Fullan");
        Payment payment = new Payment();
        payment.PaymentMaker();
        Order order = new Order();
        order.OrderRecived();
        Cheif cheif = new Cheif();
        cheif.OrderHasBeenTaken();
    }
}




}