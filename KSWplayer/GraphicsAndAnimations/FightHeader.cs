using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KSWplayer.Graphics
{
    class FightHeader
    {
        
        public static void Display()
        {
            char x = (char)92;
            
            Console.CursorVisible = false;

            Console.WriteLine("\n");
            Console.WriteLine("        ___     ___    ___       ______       ___           ____     ____       ______          _____");
            Console.WriteLine($"       |   |   |   |  |   |     /      {x}     |   |         |    |   /   /      /      {x}        /     |");
            Console.WriteLine($"       |   |   |   |  |   |    /   /{x}   {x}    |   |         |    |  /   /      /   /{x}   {x}      /      |");
            Console.WriteLine($"       |   |   |   |  |   |   /   /  {x}   {x}   |   |         |    | /   /      /   /  {x}   {x}    /__/|   |");
            Console.WriteLine($"       |   |   |   |  |   |  |   |____|   |  |   |         |    |/   /      |   |____|   |       |   |");
            Console.WriteLine($"       |   |   |   |  |   |  |    ____    |  |   |         |         {x}      |    ____    |       |   |");
            Console.WriteLine($"       |   |   |   |  |   |  |   |    |   |  |   |         |    |{x}    {x}     |   |    |   |       |   |");
            Console.WriteLine($"       {x}   {x}__ |   |__|   |  |   |    |   |  |    {x}_____   |    | {x}    {x}    |   |    |   |    ___|   |___    ___");
            Console.WriteLine($"        {x}_                |  |   |    |   |   {x}_        |  |    |  {x}    {x}   |   |    |   |   /           {x}  |   |");
            Console.WriteLine($"          {x}_____________ /   |___|    |___|     {x}_______|  |____|   {x}____{x}  |___|    |___|  |_____________| |___|");
            
        }

        public static void Animation()
        {
            Console.Clear();

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Thread.Sleep(50*i);
                    Display();
                    Thread.Sleep(50*i);
                    Console.Clear();
                }
            }
            
            Display();
        }

    }
}
