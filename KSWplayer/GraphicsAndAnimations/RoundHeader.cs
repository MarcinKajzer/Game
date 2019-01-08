using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer
{
    class RoundHeader
    {
        public static void Display(int i)
        {
            Console.WriteLine();
            Console.WriteLine("           __                                         __"); 
            Console.WriteLine("           ||-----------------------------------------||"); 
            Console.WriteLine("          /||----------------------------------------/||");
            Console.WriteLine("         //||---------------------------------------//||_");
            Console.WriteLine("      __///||                                   __ ///||/|");
            Console.WriteLine("      ||========================================||///  / |");
            Console.WriteLine("      ||========================================||//  /  |");
            Console.WriteLine("     /||========================================||/  /   /");
            Console.WriteLine("    / ||                                        ||  /   /");
            Console.WriteLine("   /_______________________________________________/   /");
            Console.WriteLine("  |                                                |  /");
            Console.WriteLine($"  |                     RUNDA {i}                    | /");
            Console.WriteLine("  |________________________________________________|/\n");
        }
    }
}
