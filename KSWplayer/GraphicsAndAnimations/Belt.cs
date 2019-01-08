using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer.GraphicsAndAnimations
{
    class Belt
    {
        

        public static void Display()
        {
            char x = (char)92;

            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("                                                     _____________");
            Console.WriteLine($"                                  __________________/             {x}__________________");
            Console.WriteLine($"                        _________/                                                   {x}_________");
            Console.WriteLine($"                    ___/                         =====================                         {x}___");
            Console.WriteLine($"                   /                                                                               {x} ");
            Console.WriteLine($"__________________/         ===============================================================         {x}_________________ ");
            Console.WriteLine($"                             {x}   ____     ____      ___________    ___     ___    ___   /           ");
            Console.WriteLine("  ___________________________|  |    |   /   /     /           /  |   |   |   |  |   |  |___________________________ ");
            Console.WriteLine($" / _   __  _____   _   _   _ |  |    |  /   /     /     ______/   |   |   |   |  |   |  | _   __  _____   _   _   _ {x} ");
            Console.WriteLine($"/ | | / / /  ___| | | | | | ||  |    | /   /     |    /           |   |   |   |  |   |  || | / / /  ___| | | | | | | {x} ");
            Console.WriteLine($"| | |/ / {x}  {x}___  | | | | | ||  |    |/   /      |    {x}_____      |   |   |   |  |   |  || |/ / {x}  {x}___  | | | | | | | ");
            Console.WriteLine($"| |   |   {x}___  {x} | | | | | ||  |         {x}       {x}______    {x}    |   |   |   |  |   |  ||   |   {x}___  {x} | | | | | | | ");
            Console.WriteLine($"| | |{x} {x}  ____/  /{x} {x}_| |_| ||  |    |{x}    {x}             {x}   {x}    |   |   |   |  |   |  || |{x} {x}  ____/  /{x} {x}_| |_| | | ");
            Console.WriteLine($"{x} |_| {x}_{x} {x}_____/  {x}________/|  |    | {x}    {x}     _______/   |     {x}   {x}__|   |__|   |  ||_| {x}_{x} {x}_____/  {x}________/ / ");
            Console.WriteLine($" {x}___________________________|  |    |  {x}    {x}   /           /      {x}_               |  |___________________________/ ");
            Console.WriteLine($"                            /   |____|   {x}____{x}  {x}__________/         {x}_____________/    {x} ");
            Console.WriteLine($"_________________          /_                                                            _{x}           ________________");
            Console.WriteLine($"                 {x}           {x}_                   - C H A M P I O N -                  _/            /");
            Console.WriteLine($"                  {x}            {x}__________________                  __________________/             / ");
            Console.WriteLine($"                   {x}___                           {x}________________/                            ___/ ");
            Console.WriteLine($"                       {x}_______                                                         _______/ ");
            Console.WriteLine($"                               {x}________          ------------------           ________/ ");
            Console.WriteLine($"                                        {x}__                                 __/ ");
            Console.WriteLine($"                                           {x}_______________________________/  ");
            Console.ReadKey();
        }
    }
}
