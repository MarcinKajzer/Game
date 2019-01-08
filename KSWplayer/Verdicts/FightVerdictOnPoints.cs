using KSWplayer.Fighters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer.Verdicts
{
    class FightVerdictOnPoints
    {
        public void GetFightVerdict(RoundVerdict roundVerdict, Queue<Fighter> rivalsQueue, IFighter player)
        {
            if (roundVerdict.WinPlayersRounds > roundVerdict.WinRivalsRounds)
            {
                IFighter directRival = rivalsQueue.First();
                rivalsQueue.Dequeue();
                player.UpgradeContracts();

                if (rivalsQueue.Count >= 1)
                {
                    Console.WriteLine(Coments.Winn());
                    Console.WriteLine($"\n  -- Już tylko {rivalsQueue.Count} zawodnik/ów na drodze do Pasa KSW. --");
                    Console.WriteLine("  -- W nagrodę odberz 3 dodatkowe punkty, by ulepszyć swojego zawodnika. --");
                    Console.ReadKey();
                    Rivals.UpgradeRivals(player, directRival);
                    PointAward.UpgradeFighter(player);
                }
                else
                {
                    Console.WriteLine("\n  -- To była już ostatnia walka w drodze na szczyty KSW. -- ");
                    Console.WriteLine("  -- Bez dwóch zdań, to właśnie Ty jesteś mistrzem.-- ");
                    Console.WriteLine("  -- Pozostaje odebrać mistrzowski pas. -- ");
                }
            }
            else if (roundVerdict.WinPlayersRounds == roundVerdict.WinRivalsRounds)
            {
                Console.WriteLine("  -- Remis, aby rozstrzygnąc kto jest lepszy, musisz stoczyć tę walkę jeszcze raz. --");
            }
            else
            {
                Console.WriteLine("  -- Niestety przegrałeś walkę na punkty. Tracisz kontrakt. Pasy KSW zdobywają mistrzowie, więc w drodze na szczyt czeka Cię rewanż. --");
                player.DowngradeContracts();
            }
            Console.WriteLine("  -- Użyj dowolnego klawisza by przejść dalej. --");
            Console.ReadKey();
        }
    }
}
