using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer
{
    static class ChoseFighterMenu
    {
        static string[] Weights = {                  "|_LEKKA_________________|", "|_PÓŁŚREDNIA___________|", "|_ŚREDNIA____________|", "|_PÓŁCIĘŻKA_________|", "|_CIĘŻKA_______________|" };
        static string[] ChoseFighterMenuPositions = {"| Mateusz Gamrot        |", "| Borys Mańkowski      |", "| Damian Janikowski  |", "| Łukasz Jurkowski  |", "| Mariusz Pudzianowski |",
                                                     "| Grzegorz Szulakowski  |", "| Roberto Soldic       |", "| Michał Materla     |", "| Tomasz Narkun     |", "| Karol Bedorf         |",
                                                     "| Gracjan Szadziński    |", "| Kamil Szymuszowski   |", "| Mamed Khalidov     |", "| Wagner Prado      |", "| Marcin Różalski      |",
                                                     "| Artur Sowiński        |", "| Dricus Du Plessis    |", "| Scot Askham        |", "| Chris Fields      |", "| Phil de Fries        |",
                                                     "| Marian Ziółkowski     |", "| Krystian Kaszubowski |", "| Marin Wójcik       |", "| Martin Zawada     |", "| Michał Andryszak     |"  };
        
        static int activePosition = 1;
        
        public static void Start()
        {
            Console.Title = "Wybór zawodnika";
            Console.CursorVisible = false;

            while (true)
            {
                DisplayMenu();
                ChooseOption();
                LaunchOption();
            }
        }

        static void DisplayMenu()
        {
            Console.Clear();
           
            Console.WriteLine("\n  >>> Na początek wybierz zadownika z listy według kategorii wagowej i zatwierdź klawiszem Enter <<<\n");
            Console.WriteLine(" __________________________________________________________________________________________________________________");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(Weights[i]);   
            }

            Console.Write("\n|                       ||                      ||                    ||                   ||                      |\n");
            
            for (int j = 0; j < 5; j++)
            {
                for (int i = 5 * j; i < 5 * j + 5; i++)
                {
                    if (i + 1 == activePosition)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write("{0,-10}", ChoseFighterMenuPositions[i]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write(ChoseFighterMenuPositions[i]);
                    }
                }

                Console.WriteLine();
            }
            
            Console.Write("|_______________________||______________________||____________________||___________________||______________________|\n");
            
            FightersInfo.Display(FightersList.AllFightersList[activePosition-1]);
        }

        static void ChooseOption()
        {
            while(true)
            {
                ConsoleKeyInfo klawisz = Console.ReadKey();
                if (klawisz.Key == ConsoleKey.UpArrow) 
                {
                    activePosition = (activePosition == 1 || activePosition == 2 || activePosition == 3 || activePosition == 4 || activePosition == 5) ? activePosition + 20 : activePosition - 5;
                    
                    DisplayMenu();
                }
                else if (klawisz.Key == ConsoleKey.DownArrow)
                {
                    activePosition = (activePosition  == 21 || activePosition == 22 || activePosition == 23 || activePosition == 24 || activePosition == 25) ? activePosition -20 : activePosition + 5;
                    
                    DisplayMenu();
                }
                else if (klawisz.Key == ConsoleKey.RightArrow)
                {
                    activePosition = (activePosition % 5 == 0 ) ? activePosition - 4 : activePosition + 1;

                    DisplayMenu();
                }
                else if (klawisz.Key == ConsoleKey.LeftArrow)
                {
                    activePosition = (activePosition % 5 == 1) ? activePosition +4 : activePosition - 1;

                    DisplayMenu();
                }
                else if (klawisz.Key == ConsoleKey.Escape)
                {
                    // czy można tak zrobić ? czy to nie jest tak, że teraz w tle pracuje metoda MainMenu.StartMenu2 - w niej uruchomiona jest
                    // metoda StartMenu i po naciśnięciu escape znów jakby wewnątrz uruchamiane jest MainMenu.StartMenu2() ? Nie lepiej referencje
                    // przekazać i zakończyć ?
                    MainMenu.Start();
                    break;
                }
                else if (klawisz.Key == ConsoleKey.Enter)
                    break;
            }
        }

        static void LaunchOption()
        {
            for (int i = 1; i <= 25; i++)
            {
                if (i == activePosition)
                {
                    Confirmation.ChoiceCharacter(FightersList.AllFightersList[i-1]);
                    break;
                }
            }
        }
    
    }
}
