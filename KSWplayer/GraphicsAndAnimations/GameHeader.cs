using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer
{
    static class GameHeader
    {
        public static void Display()
        {
            char u = (char)92;

            Console.Title = "KSWplayer";
            Console.SetWindowSize(120, 30);
            
            Console.WriteLine("   -------------------------------------------------------------");
            Console.WriteLine("  |    ____     ____      ___________     ___     ___    ___    |    ");
            Console.WriteLine("  |   |    |   /   /     /           /   |   |   |   |  |   |   |");
            Console.WriteLine("  |   |    |  /   /     /     ______/    |   |   |   |  |   |   |");
            Console.WriteLine("  |   |    | /   /     |    /            |   |   |   |  |   |   |");
            Console.WriteLine($"  |   |    |/   /      |    {u}_____       |   |   |   |  |   |   |");
            Console.WriteLine($"  |   |         {u}       {u}______    {u}     |   |   |   |  |   |   |");
            Console.WriteLine($"  |   |    |{u}    {u}             {u}    {u}    |   |   |   |  |   |   |");
            Console.WriteLine($"  |   |    | {u}    {u}     _______/    |     {u}   {u}__|   |__|   |   |");
            Console.WriteLine($"  |   |    |  {u}    {u}   /           /       {u}_               |   |");
            Console.WriteLine($"  |   |____|   {u}____{u}  {u}__________/          {u}_____________/    |");
            Console.WriteLine("  |                                                             |");
            Console.WriteLine("   -----------------------PLAYER--2018--------------------------   ");
            Console.WriteLine();
           
        }
       
    }
}
