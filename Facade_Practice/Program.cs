using System;

namespace Facade_Practice
{

    class CPU
    {
        public void proccessData()
        {
            Console.WriteLine("proccessing Data");
        }
    }

    class Memory
    {
        public void load()
        {
            Console.WriteLine("Loaded");
        }
    }

    class HardDrive
    {
        public void readData()
        {
            Console.WriteLine("reading data");
        }
    }

    class Computer
    {
        CPU cpu = new CPU();
        Memory memory = new Memory();
        HardDrive hardDrive = new HardDrive();

        public void run()
        {
            cpu.proccessData();
            memory.load();
            hardDrive.readData();
        }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.run();
        }
    }
}
