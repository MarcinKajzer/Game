using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer
{
    class FightersInfo
    {
        public static void Display(IFighter Fighter)
        {
            Console.WriteLine($"\n\n  Zawodnik: {Fighter.name}");
            Console.WriteLine($"\n  Pseudonim: {Fighter.pseudonym}");
            Console.WriteLine($"\n  Wzrost: {Fighter.heigth}");
            Console.WriteLine($"\n  Waga: {Fighter.weight}");
            Console.WriteLine($"\n  Umiejętności w parterze: {Fighter.parter}");
            Console.WriteLine($"\n  Umiejętności w stójce: {Fighter.stojka}");
            Console.WriteLine($"\n  Wytrzymałość: {Fighter.energy + Fighter.extraEnergy}");
        }

        public static void Compare(IFighter fighter1, IFighter fighter2)
        {
            // tu jeszcze mozna sformatować tekst zamiast pisać spacje, ale na chwilę obecną nie ma to znaczenia.

            Console.WriteLine($"\n                                {fighter1.name}        VS        {fighter2.name}\n\n");

            Console.Write($"  Pseudonim:                    {fighter1.pseudonym}");
            for (int i = 0; i < fighter1.name.Length-fighter1.pseudonym.Length + 18; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine($"{fighter2.pseudonym}");
            
            Console.Write($"  Wzrost:                       {fighter1.heigth}");
            for (int i = 0; i < fighter1.name.Length + 18 - fighter1.heigth.ToString().Length; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine($"{fighter2.heigth}");
            
            Console.Write($"  Waga:                         {fighter1.weight}");
            for (int i = 0; i < fighter1.name.Length + 18 - fighter1.weight.ToString().Length; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine($"{fighter2.weight}");

            Console.Write($"  Doświadczenie w parterze:     {fighter1.parter}");
            for (int i = 0; i < fighter1.name.Length + 18 - fighter1.parter.ToString().Length; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine($"{fighter2.parter}");
            
            Console.Write($"  Doświadczenie w stójce:       {fighter1.stojka}");
            for (int i = 0; i < fighter1.name.Length + 18 - fighter1.stojka.ToString().Length; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine($"{fighter2.stojka}");

            Console.Write($"  Wytrzymałość (energia):       {fighter1.energy + fighter1.extraEnergy}");
            for (int i = 0; i < fighter1.name.Length + 18 - (fighter1.energy + fighter1.extraEnergy).ToString().Length; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine($"{fighter2.energy + fighter2.extraEnergy}");
            
            Console.WriteLine("\n\n\n  -- Wciśnij dowolny przycisk, kiedy będziesz gotowy, by zacząć walkę. --");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
