using System;
namespace FacadePattren
{
    class Monitor : IProcess
    {
        public void Off()
        {
            Console.WriteLine("Monitor off .. see soon ^^");
        }

        public void On()
        {
            Console.WriteLine("Monitor on");
        }
    }
}
