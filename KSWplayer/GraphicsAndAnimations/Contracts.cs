using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer.GraphicsAndAnimations
{
    class Contracts
    {
        public static void Display(IFighter Player)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("\n  Twoje kontrakty: ");
            for (int i = 0; i < Player.GetContractsNumber(); i++)
            {
                Console.Write(" \u2665");
            }
        }
    }
}
