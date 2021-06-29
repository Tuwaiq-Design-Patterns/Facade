using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new Computer();
            
            computer.PrintCpuInfo();
            computer.PrintMemoryInfo();
            computer.PrintIOInfo();
        }
    }

    public class Computer
    {
        private readonly Cpu _cpu;
        private readonly Memory _memory;
        private readonly IO _io;

        public Computer()
        {
            _cpu = new Cpu();
            _memory = new Memory();
            _io = new IO();
        }
        
        public void PrintCpuInfo()
        {
            _cpu.PrintInfo();
        }
        
        public void PrintMemoryInfo()
        {
            _memory.PrintInfo();
        }
        
        public void PrintIOInfo()
        {
            _io.PrintInfo();
        }
    }

    public interface ComputerComponents
    {
        public void PrintInfo();
    }

    public class Cpu : ComputerComponents
    {
        public void PrintInfo()
        {
            Console.WriteLine("something usefull using CPU provided by OS kernel");
        }
    }

    public class Memory : ComputerComponents
    {
        public void PrintInfo()
        {
            Console.WriteLine("something usefull using Memory provided by OS kernel");
        }
    }

    public class IO : ComputerComponents
    {
        public void PrintInfo()
        {
            Console.WriteLine("something usefull using I/O devices provided by OS kernel");
        }
    }
}