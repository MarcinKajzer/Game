using KSWplayer.Fighters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KSWplayer.Verdicts
{
    class FightVerdictBeforeTime
    {
        public static void Winn(IFighter fighter, IFighter directRival, int roundNumber)
        {
            if (fighter.corner == "player")
            {
                fighter.UpgradeContracts();

                Thread.Sleep(1000);
                Console.WriteLine($"  Wygrana w {roundNumber} rundzie.");
                Console.WriteLine(Coments.Winn());
                Console.WriteLine("\n  -- W nagrodę odberz 3 dodatkowe punkty by ulepszyć swojego zawodnika. --");
                Console.WriteLine("  -- Użyj dowolnego klawisza, aby odebrać zasłużone punkty. --");
                Console.ReadKey();
                Rivals.UpgradeRivals(fighter, directRival);
                PointAward.UpgradeFighter(fighter);
            }
        }

        public static void Loss(IFighter fighter, int roundNumber)
        {
            if (fighter.corner == "player")
            {
                fighter.DowngradeContracts();
                Console.WriteLine($"  Przegrana w {roundNumber} rundzie.");
                Console.WriteLine(Coments.Loss());
            }

        }
    }
}
