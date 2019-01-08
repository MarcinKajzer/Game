using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer.Verdicts
{
    class RoundVerdict
    {
        public int WinPlayersRounds { get; private set; }

        public int WinRivalsRounds { get; private set; }

        public void GetRoundVerdict(IFighter fighter1, IFighter fighter2, int roundNumber)
        {
            if (roundNumber == 1)
            {
                WinPlayersRounds = 0;
                WinRivalsRounds = 0;
            }

            if (fighter1.GetEnergyValue() > fighter2.GetEnergyValue() && fighter2.GetEnergyValue() != 0)
            {
                Console.WriteLine($"  Tę rundę wygrał: {fighter1.name}");
                WinPlayersRounds += 1;
            }
            else if (fighter1.GetEnergyValue() < fighter2.GetEnergyValue() && fighter1.GetEnergyValue() != 0)
            {
                Console.WriteLine($"  Tę rundę wygrał: {fighter2.name}");
                WinRivalsRounds += 1;
            }
            else if (fighter2.GetEnergyValue() != 0 && fighter1.GetEnergyValue() != 0)
            {
                Console.WriteLine("  Runda remisowa. ");
                WinRivalsRounds += 1;
                WinPlayersRounds += 1;
            }
        }
    }
}
