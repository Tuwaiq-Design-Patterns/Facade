using System;
using System.Collections.Generic;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var fac = new Facade();
            fac.Controllers = new List<Controller>
            {
                new ControllerA("first A"),
                new ControllerA("second A"),
                new ControllerA("third A"),
                
                new ControllerB("first B"),
                new ControllerB("second B"),
                new ControllerB("third B")
            };
            
            fac.operation("A");
            fac.operation("B");
        }
    }

    public class Facade
    {
        public List<Controller> Controllers { get; set; }
        
        public void operation(string type)
        {
            if (type.Equals("A"))
            {
                foreach (var controller in Controllers)
                {
                    if(controller is ControllerA)
                        controller.Operation();
                }
            }
            else
            {
                foreach (var controller in Controllers)
                {
                    if(controller is ControllerB)
                        controller.Operation();
                }
            }
        }
    }

    public interface Controller
    {
        public void Operation();
    }
    
    public class ControllerA : Controller
    {
        public string Name { get; set; }

        public ControllerA(string name)
        {
            this.Name = name;
        }

        public void Operation()
        {
            Console.WriteLine(Name + " controller A");
        }
    }
    
    public class ControllerB : Controller
    {
        public string Name { get; set; }
        
        public ControllerB(string name)
        {
            this.Name = name;
        }

        public void Operation()
        {
            Console.WriteLine(Name + " controller B");
        }
    }
}