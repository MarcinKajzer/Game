using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KSWplayer
{
    class CountingDown
    {
        static void DisplayNumberOne()
        {
            char u = (char)92;

            Console.WriteLine("\n\n\n\n");
            Console.CursorLeft = 45; Console.WriteLine("       _________");
            Console.CursorLeft = 45; Console.WriteLine("      /         |");
            Console.CursorLeft = 45; Console.WriteLine("     /          |");
            Console.CursorLeft = 45; Console.WriteLine("    /     /     |");
            Console.CursorLeft = 45; Console.WriteLine("   /     /|     |");
            Console.CursorLeft = 45; Console.WriteLine($"   {u}____/ |     |");
            Console.CursorLeft = 45; Console.WriteLine("          |     |");
            Console.CursorLeft = 45; Console.WriteLine("          |     |");
            Console.CursorLeft = 45; Console.WriteLine("          |     |");
            Console.CursorLeft = 45; Console.WriteLine("          |     |");
            Console.CursorLeft = 45; Console.WriteLine("          |     |");
            Console.CursorLeft = 45; Console.WriteLine("          |     |");
            Console.CursorLeft = 45; Console.WriteLine("    ______|     |______");
            Console.CursorLeft = 45; Console.WriteLine("   |                   |");
            Console.CursorLeft = 45; Console.WriteLine("   |___________________|");
            
        }

        static void DisplayNumberTwo()
        {
            char u = (char)92;

            Console.WriteLine("\n\n\n");
            Console.CursorLeft = 45; Console.WriteLine("          _________ ");
            Console.CursorLeft = 45; Console.WriteLine($"        _/         {u}_");
            Console.CursorLeft = 45; Console.WriteLine($"      _/     __      {u}_");
            Console.CursorLeft = 45; Console.WriteLine($"     /     _/  {u}_      {u} ");
            Console.CursorLeft = 45; Console.WriteLine($"    /     /      {u}      |");
            Console.CursorLeft = 45; Console.WriteLine("    |_____|       |     | ");
            Console.CursorLeft = 45; Console.WriteLine("                  /     |");
            Console.CursorLeft = 45; Console.WriteLine("                _/    _/ ");
            Console.CursorLeft = 45; Console.WriteLine("               /     /  ");
            Console.CursorLeft = 45; Console.WriteLine("             _/    _/");
            Console.CursorLeft = 45; Console.WriteLine("            /     /");
            Console.CursorLeft = 45; Console.WriteLine("          _/    _/");
            Console.CursorLeft = 45; Console.WriteLine("         /     /");
            Console.CursorLeft = 45; Console.WriteLine("       _/     /_________ ");
            Console.CursorLeft = 45; Console.WriteLine("      /                 |");
            Console.CursorLeft = 45; Console.WriteLine("     |                  |");
            Console.CursorLeft = 45; Console.WriteLine("     |__________________|");
        }


        static void DisplayNumberThree()
        {
            char u = (char)92;

            Console.WriteLine("\n\n\n");
            Console.CursorLeft = 45; Console.WriteLine("          _________ ");
            Console.CursorLeft = 45; Console.WriteLine($"        _/         {u}_");
            Console.CursorLeft = 45; Console.WriteLine($"      _/     __      {u}_");
            Console.CursorLeft = 45; Console.WriteLine($"     /     _/  {u}_      {u} ");
            Console.CursorLeft = 45; Console.WriteLine($"    /     /      {u}      |");
            Console.CursorLeft = 45; Console.WriteLine("    |_____|       |     | ");
            Console.CursorLeft = 45; Console.WriteLine("                  /     |");
            Console.CursorLeft = 45; Console.WriteLine("                _/    _/ ");
            Console.CursorLeft = 45; Console.WriteLine("             __/     / ");
            Console.CursorLeft = 45; Console.WriteLine("            |       /");
            Console.CursorLeft = 45; Console.WriteLine($"            |__     {u} ");
            Console.CursorLeft = 45; Console.WriteLine($"               {u}_    {u}_");
            Console.CursorLeft = 45; Console.WriteLine($"                 {u}     {u} ");
            Console.CursorLeft = 45; Console.WriteLine($"     _____        {u}     |");
            Console.CursorLeft = 45; Console.WriteLine("    |     |       |     |  ");
            Console.CursorLeft = 45; Console.WriteLine($"    {u}     {u}_    __/     |");
            Console.CursorLeft = 45; Console.WriteLine($"     {u}_     {u}__/      _/");
            Console.CursorLeft = 45; Console.WriteLine($"       {u}_           _/");
            Console.CursorLeft = 45; Console.WriteLine($"         {u}_________/ ");
        }
            
        public static void CountBeforeFight()
        {
            Console.CursorVisible = false;
            Console.Clear();
            DisplayNumberThree(); Thread.Sleep(500);
            Console.Clear(); Thread.Sleep(500);
            DisplayNumberTwo(); Thread.Sleep(500);
            Console.Clear(); Thread.Sleep(500);
            DisplayNumberOne(); Thread.Sleep(500);
            Console.Clear();
        }
    }
}
