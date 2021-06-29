using System;
namespace FacadePattren
{
    class Keyboard : IProcess
    {
        public void Off()
        {
            Console.WriteLine("Keyboard off");
            TurnOffBacklit();
        }

        public void On()
        {
            Console.WriteLine("Keyboard on");
            TurnOnBacklit();
        }

        public void TurnOnBacklit()
        {
            Console.WriteLine("Keyboard lights on");
        }
        public void TurnOffBacklit()
        {
            Console.WriteLine("Keyboard lights off");
        }
    }
}
