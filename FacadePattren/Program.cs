using System;
using System.Collections.Generic;

namespace FacadePattren
{

    class ComputerFacade
    {
        private CPU processor = new CPU();
        private Memory ram = new Memory();
        private HardDrive hd = new HardDrive();
        private Monitor monitor = new Monitor();
        private Keyboard keyboard = new Keyboard();

        private const long BOOT_ADDRESS = 00000;
        private const long BOOT_SECTOR = 00000;
        private const int SECTOR_SIZE = 0;

        public void ComputerTurnOn()
        {
            processor.On();
            monitor.On();
            keyboard.On();
            ram.Load(BOOT_ADDRESS, hd.Read(BOOT_SECTOR, SECTOR_SIZE));
            processor.Jump(BOOT_ADDRESS);
            processor.Excute();
        }

        public void ComputerSleep()
        {
            processor.Freeze();
        }

        public void ComputerTurnOff()
        {
            processor.Off();
            monitor.Off();
            keyboard.Off();
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            Menu menu = new Menu();
            try
            {
                menu.mainMenu();
            }
            catch
            {
                throw new ArgumentNullException("Error");
            }
        }
    }
}
