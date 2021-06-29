using System;

namespace facade
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Casher casher = new Casher();
            casher.ClientOrder();
        }
    }
}
