using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer
{
    static class MainMenu
    {
        static string[] pozitionsList = { "   SINGLEPLAYER", "   MULTIPLAYER", "   BEZ KATEGORII", "   O GRZE", "   USTAWIENIA","   ZAKOŃCZ" };
                             
        static int activePosition = 1;
        
        public static void Start()
        {
            Console.Title = "Menu główne";
            Console.CursorVisible = false;

            while (true)
            {
                DisplayMenu();
                ChoseOption();
                LaunchOption();
            }
        }

        static void DisplayMenu()
        {
            Console.Clear();
            GameHeader.Display();

            for (int i = 0; i < pozitionsList.Length; i++)
            {
                if (i + 1 == activePosition)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("{0,-30}", pozitionsList[i]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine(pozitionsList[i]);
                }
            }
        }

        static void ChoseOption()
        {
            while(true)
            {
                ConsoleKeyInfo klawisz = Console.ReadKey();
                if (klawisz.Key == ConsoleKey.UpArrow) 
                {
                    activePosition = (activePosition == 1) ? activePosition = pozitionsList.Length  : activePosition - 1;
                    
                    DisplayMenu();
                }
                else if (klawisz.Key == ConsoleKey.DownArrow)
                {
                    activePosition = (activePosition  == pozitionsList.Length) ? activePosition = 1 : activePosition + 1;
                    
                    DisplayMenu();
                }
                else if (klawisz.Key == ConsoleKey.Escape)
                {
                    activePosition = pozitionsList.Length - 1;
                    break;
                }
                else if (klawisz.Key == ConsoleKey.Enter)
                    break;
            }
        }

        static void LaunchOption()
        {
            switch (activePosition)
            {
                case 1:
                    ChoseFighterMenu.Start();
                    break;
                case 2:
                    Console.Clear();
                    opcjaWBudowie2();
                    break;
                case 3:
                    Console.Clear();
                    opcjaWBudowie2();
                    break;
                case 4:
                    Console.Clear();
                    opcjaWBudowie2();
                    break;
                case 5:
                    Console.Clear();
                    opcjaWBudowie2();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }
        }

        static void opcjaWBudowie2()
        {
            Console.SetCursorPosition(50, 10);
            Console.WriteLine("Opcja w budowie !");
            Console.ReadKey();
        }
    }
}
