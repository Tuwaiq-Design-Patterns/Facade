using System;

namespace Facade.Structural
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Roastery roastery = new Roastery();

            roastery.LightRoastAndGrind();
            roastery.LightRoastNoGrind();
            roastery.DarkRoastAndGrind();

            Console.ReadKey();
        }
    }


    public class BringBeans
    {
        public void BringCoffeBeans()
        {
            Console.WriteLine("Bring coffe beans");
        }
    }


    public class LightRoast
    {
        public void LightRoastCoffeBeans()
        {
            Console.WriteLine("Light Roast coffe beans");
        }
    }

    public class MediumRoast
    {
        public void MediumRoastCoffeBeans()
        {
            Console.WriteLine("Meduim Roast coffe beans");
        }
    }

    public class DarkRoast
    {
        public void DarkRoastCoffeBeans()
        {
            Console.WriteLine("Dark Roast coffe beans");
        }
    }


    public class GrindBeans
    {
        public void GrindCoffeBeans()
        {
            Console.WriteLine("Grind coffe beans");
        }
    }
   

    public class Roastery
    {
        BringBeans bringBeans;
        LightRoast lightRoastBeans;
        MediumRoast mediumRoastBeans;
        DarkRoast darkRoastBeans;
        GrindBeans grindBeans;

        public Roastery()
        {
            bringBeans = new BringBeans();
            lightRoastBeans = new LightRoast();
            mediumRoastBeans = new MediumRoast();
            darkRoastBeans = new DarkRoast();
            grindBeans = new GrindBeans();
        }

        public void LightRoastAndGrind()
        {
            Console.WriteLine("\nA customer wants to buy grounded, lightly roasted coffe beans ");
            bringBeans.BringCoffeBeans();
            lightRoastBeans.LightRoastCoffeBeans();
            grindBeans.GrindCoffeBeans();
        }

        public void LightRoastNoGrind()
        {
            Console.WriteLine("\nA customer wants to buy non-grounded, lightly roasted beans");
            bringBeans.BringCoffeBeans();
            lightRoastBeans.LightRoastCoffeBeans();
        }

        public void DarkRoastAndGrind()
        {
            Console.WriteLine("\nA customer wants to buy grounded, dark roasted beans");
            bringBeans.BringCoffeBeans();
            darkRoastBeans.DarkRoastCoffeBeans();
            grindBeans.GrindCoffeBeans();
        }
        
    }
}
