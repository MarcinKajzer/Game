using KSWplayer.Fighters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KSWplayer
{
    class PointAward
    {
        public static void UpgradeFighter(IFighter fighter)
        {
            while (true)
            {
                Console.Clear();
                fighter.ResetEnergy();

                Console.WriteLine("\n  Twój zawodnik przedstawia się następująco: ");
                Console.WriteLine($"\n  >> Wytrzymałość podczas walki (energia): {fighter.energy + fighter.extraEnergy}");
                Console.WriteLine($"  >> Doświadczenie w stójce: {fighter.stojka}");
                Console.WriteLine($"  >> Doświadczenie w parterze: {fighter.parter}");

                Console.WriteLine("\n  Otrzymujesz 3 ekstra punkt, do przydzielenia swojej postaci.\n  Przydziel je poszczególnym pozycjom według uznania\n");

                int energyUpgradeValue;

                int stojkaUpgradeValue;
                int parterUpgradeValue;
                
                try
                {
                    Console.Write("  >> Energia: ");
                    energyUpgradeValue = int.Parse(Console.ReadLine());
                    if (energyUpgradeValue < 0 || energyUpgradeValue > 3)
                    {
                        Console.WriteLine("  Niepoprawna wartość !!!");
                        Thread.Sleep(1500);
                        continue;
                    }

                    Console.Write("\n  >> Stójka: ");
                    stojkaUpgradeValue = int.Parse(Console.ReadLine());
                    if (stojkaUpgradeValue < 0 || stojkaUpgradeValue > 3 - energyUpgradeValue)
                    {
                        Console.WriteLine("  Niepoprawna wartość !!!");
                        Thread.Sleep(1500);
                        continue;
                    }

                    Console.Write("\n  >> Parter: ");
                    parterUpgradeValue = int.Parse(Console.ReadLine());
                    if (parterUpgradeValue < 0 || parterUpgradeValue > 3 - energyUpgradeValue - stojkaUpgradeValue)
                    {
                        Console.WriteLine("  Niepoprawna wartość !!!");
                        Thread.Sleep(1500);
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("  Możesz jedynie użyć cyfr od 0 do 3 !!!");
                    Thread.Sleep(1500);
                    continue;
                }

                fighter.UpgradeParter(parterUpgradeValue);
                fighter.UpgradeStojka(stojkaUpgradeValue);
                fighter.UpgradeEnergy(energyUpgradeValue);
                break;
            }
            
            Console.WriteLine("\n\n  Twój zawodnik po awansie punktowym: ");
            Console.WriteLine($"\n  >> Wytrzymałość podczas walki (energia): {fighter.energy + fighter.extraEnergy}");
            Console.WriteLine($"  >> Doświadczenie w stójce: {fighter.stojka}");
            Console.WriteLine($"  >> Doświadczenie w parterze: {fighter.parter}");
            Console.WriteLine("\n\n\n  Użyj dowolnego przycisku, gdy będziesz gotowy na kolejną walkę.");
            
        }
    }
}
