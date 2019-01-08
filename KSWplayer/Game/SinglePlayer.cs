using KSWplayer.Fighters;
using KSWplayer.GraphicsAndAnimations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace KSWplayer
{
    class SinglePlayer
    {
        public static void BeginPlay(IFighter player)
        {
            player.SetCornerAsPlayer();

            Queue<Fighter> RivalsQueue = Rivals.CreateQueue(player);
            
            while (RivalsQueue.Count >= 1)
            {
                if (RivalsQueue.Count() == 4 && player.GetContractsNumber() > 1)
                {
                    Console.WriteLine("  -- Tym zawodnikiem zdobyłeś już wszystko, co mogłeś zdziałać w KSW. -- ");
                    Console.WriteLine("  -- Teraz możesz próbować odebrać mistrzowski pas, jako jeden z pozostałych fighter'ów. --");
                    Console.WriteLine("  -- Pamiętaj, że dzięki walkom z Tobą i nie tylko, także oni są teraz silniejszymi zawodnikami. --");
                    Console.WriteLine("\n  -- Użyj dowolnego przycisku, by wrócić do menu SinglePlayer. --");
                    Console.ReadKey();
                    ChoseFighterMenu.Start();
                }
                else if (player.GetContractsNumber() >= 1)
                {
                    DuelElements.Fight(player, RivalsQueue.First(), RivalsQueue);
                }
                else
                {
                    Console.WriteLine("\n  -- Przykro nam. Straciłeś wszystkie kontrakty, włodaże KSW nie mają póki co więcej walk dla Ciebie. --");
                    Console.WriteLine($"  -- Przegrana tym zawodnikiem uniemożliwia Ci dalsze próby zdobywania pasa jako {player.name} w bieżącej sesji. --");
                    Console.WriteLine("  -- Możesz się z nim zmierzyć jedyne jako przeciwnik. --");
                    Console.WriteLine("\n  -- Użyj dowolnego przycisku, by wrócić do menu SinglePlayer. --");
                    Console.ReadKey();
                    
                    player.ResetCorner();
                    ChoseFighterMenu.Start();
                }
                        
            }
            
            Belt.Display();
            player.ResetCorner();
            ChoseFighterMenu.Start();
        }
    }
}
