using System;
namespace FacadePattren
{
    public class CPU : IProcess
    {
        public void On()
        {
            Console.WriteLine("Processor on");
        }

        public void Freeze()
        {
            Console.WriteLine("Take a nap ~_~");
        }

        public void Jump(long position) { }
        public void Excute() { }

        public void Off()
        {
            Console.WriteLine("Processor off");
        }
    }
}
