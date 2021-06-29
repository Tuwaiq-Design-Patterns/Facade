using System;

namespace Facade
{
    public class Computer
    {
        protected Cpu _cpu;

        protected Ram _ram;

        public Computer(Cpu cpu, Ram ram)
        {
            this._cpu = cpu;
            this._ram = ram;
        }
        public string Startup()
        {
            string startup = "The computer is booting up. \n";

            startup += this._cpu.Arithmatic();
            startup += this._ram.Read();

            startup += "The computer is performing a logic operation and writing " +
                "the result into the ram. \n";

            startup += this._cpu.Logic();
            startup += this._ram.Write();

            return startup;
        }
    }
    public class Cpu
    {
        public string Arithmatic()
        {
            return "The CPU is performing an arithmatic operation. \n";
        }

        public string Logic()
        {
            return "The CPU is doing a logical comparison. \n";
        }
    }
    public class Ram
    {
        public string Read()
        {
            return "The ram is locating a word. \n";
        }
        public string Write()
        {
            return "The ram is currently writing. \n";
        }
    }
    class UserClient
    {
        public static void Client(Computer facade)
        {
            Console.Write(facade.Startup());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cpu cpu = new Cpu();
            Ram ram = new Ram();
            Computer computer = new Computer(cpu, ram);
            UserClient.Client(computer);
        }
    }
}
