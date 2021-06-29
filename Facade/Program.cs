using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeFacade homeFacade = new HomeFacade();
            Console.WriteLine("--------------- Leave Home for Office Control ----------------");
            homeFacade.LeaveHomeforOffice();
            Console.WriteLine("--------------- Arrive Home From Office Control ----------------");
            homeFacade.ArriveHomefromOffice();
            Console.ReadLine();

        }
    }

    //'SubsystemA'
    public class Lights
    {
        public void switchOnLights()
        {
            Console.WriteLine("Lights - Switched ON");
        }
        public void switchOffLights()
        {
            Console.WriteLine("Lights - Switched OFF");
        }
    }
    //'SubsystemB'
 
    public class TV
    {
        public void switchOnTV()
        {
            Console.WriteLine("TV - Switched ON");
        }
        public void switchOffTV()
        {
            Console.WriteLine("TV - Switched OFF");
        }
    }
   

   
    //'Facade'
    public class HomeFacade
    {
        Lights light;
       
        TV tv;
       
        
        public HomeFacade()
        {
            light = new Lights();
            
            tv = new TV();
           
        }
        public void LeaveHomeforOffice()
        {
            light.switchOffLights();
            
            tv.switchOffTV();
         
        }
        public void ArriveHomefromOffice()
        {
            light.switchOnLights();
           
            tv.switchOnTV();
           
        }
    }
}
