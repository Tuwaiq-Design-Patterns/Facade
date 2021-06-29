using System;
using System.Collections.Generic;

namespace FacadePattren
{
    public class Menu
    {
        static int indexMainMenu = 0;

        public void mainMenu()
        {
            ComputerFacade computer = new ComputerFacade();
            Console.WriteLine("This is an application that simulates the process of turning on and off a computer \n\nChoose from menu the action that you want");

            List<string> menuItems = new List<string>()
            {
                "Turn On",
                "Sleep",
                "Turn Off",
                "Exit"
            };

            Console.CursorVisible = false;
            while (true)
            {
                string selectedMenuItem = drawMainMenu(menuItems);
                if (selectedMenuItem == "Turn On")
                    computer.ComputerTurnOn();

                else if (selectedMenuItem == "Sleep")
                    computer.ComputerSleep();

                else if (selectedMenuItem == "Turn Off")
                    computer.ComputerTurnOff();

                else if (selectedMenuItem == "Exit")
                    Environment.Exit(0);
            }
        }

        public static string drawMainMenu(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i == indexMainMenu)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(items[i]);
                }
                else
                {
                    Console.WriteLine(items[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo ckey = Console.ReadKey();
            if (ckey.Key == ConsoleKey.DownArrow)
            {
                if (indexMainMenu == items.Count - 1) { }
                else { indexMainMenu++; }
            }
            else if (ckey.Key == ConsoleKey.UpArrow)
            {
                indexMainMenu--;
            }
            else if (ckey.Key == ConsoleKey.LeftArrow || ckey.Key == ConsoleKey.RightArrow)
            {
                Console.Clear();
            }

            else if (ckey.Key == ConsoleKey.Enter)
            {
                return items[indexMainMenu];
            }
            else
            {
                return "";
            }

            Console.Clear();
            return "";
        }

    }
}
