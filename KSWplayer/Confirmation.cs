using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KSWplayer
{
    class Confirmation
    {
        public static void ChoiceCharacter(IFighter Player)
        {
            Console.WriteLine("\n  Czy na pewno chcesz wyruszć w drogę o pas KSW tym zawodnikiem?");
            Console.WriteLine("\n  T - TAK");
            Console.WriteLine("  N - NIE");

            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            { 
                case ConsoleKey.T:
                    
                    Instructions.BeforeGame(Player);
                    SinglePlayer.BeginPlay(Player);
                    break;

                case ConsoleKey.N:
                case ConsoleKey.Escape:
                    break;

                default:
                    Console.WriteLine("\n  Niepoprawny klawisz !!!");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }
}
