using System;

namespace FacadeClass
{



    class Washing
    {
        public void print()
        {
            Console.WriteLine("Wash");
        }
    }
    class Rinsing
    {


        public void print()
        {
            Console.WriteLine("Rinse");
        }
    }

    class Spinning
    {

        public void print()
        {
            Console.WriteLine("Spine");
        }

    }
    class WashingMachime
    {
        Washing w = new Washing();
       
        Rinsing r = new Rinsing();
        Spinning s = new Spinning();

        public WashingMachime()
        {
            w.print();
            r.print();
            s.print();
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            WashingMachime wash = new WashingMachime();

        }
    }
}
