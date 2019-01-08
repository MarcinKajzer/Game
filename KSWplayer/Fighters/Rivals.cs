using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer.Fighters
{
    class Rivals
    {
        public static Queue<Fighter> CreateQueue(IFighter player)
        {
            Queue<Fighter> RivalQueue = new Queue<Fighter>();

            foreach (Fighter fighter in FightersList.AllFightersList)
            {
                if (fighter.weightCategory == player.weightCategory && fighter != player)
                {
                    RivalQueue.Enqueue(fighter);
                }

            }

            return RivalQueue;
        }

        public static void UpgradeRivals(IFighter player, IFighter directRival)
        {
            for (int i = 0; i < FightersList.AllFightersList.Length; i++)
            {
                if (FightersList.AllFightersList[i].weightCategory == player.weightCategory && FightersList.AllFightersList[i] != directRival)
                {
                    FightersList.AllFightersList[i].UpgradeStojka(1);
                    FightersList.AllFightersList[i].UpgradeParter(1);
                    FightersList.AllFightersList[i].UpgradeEnergy(1);
                }
            }
        }
    }
}
