using System;

namespace FacadePattren
{
    public class CPU
    {
        public void Freeze() { Console.WriteLine("Start"); }
        public void Jump(long position) { }
        public void Excute() { }
        public void Close() { Console.WriteLine("Shut Down"); }
    }

    class Memory
    {
        public void Load(long position, byte[] data) { }

    }

    class HardDrive
    {
        public byte[] Read(long lba, int size) {
            return new Byte[5];
        }
    }

    class ComputerFacade
    {
        private CPU processor = new CPU();
        private Memory ram = new Memory();
        private HardDrive hd = new HardDrive();
        private const long BOOT_ADDRESS = 00000;
        private const long BOOT_SECTOR = 00000;
        private const int SECTOR_SIZE = 0;

        public void Start()
        {
            processor.Freeze();
            ram.Load(BOOT_ADDRESS, hd.Read(BOOT_SECTOR, SECTOR_SIZE));
            processor.Jump(BOOT_ADDRESS);
            processor.Excute();
        }

        public void ShutDown()
        {
            processor.Close();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ComputerFacade computer = new ComputerFacade();

            try
            {
                computer.Start();
                Console.WriteLine("---------");
                computer.ShutDown();
            }
            catch
            {
                throw new ArgumentNullException("computer cannot be null");
            }

        }
    }
}
