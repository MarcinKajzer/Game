using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KSWplayer
{
    class StartLoading
    {
        public static void Loading()
        {
                Console.Clear();
                Console.SetCursorPosition(51, 9);
                Console.WriteLine("Ładowanie gry...");
                Console.CursorVisible = false;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition(46, 11);

                for (int j = 0; j<25; j++)
                {
                    Thread.Sleep(200);
                    Console.Write(" ");
                }

                Console.BackgroundColor = ConsoleColor.Black;
        }
        
    }
}
