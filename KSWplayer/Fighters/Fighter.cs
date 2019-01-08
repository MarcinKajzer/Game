using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer
{
    class Fighter : IFighter
    {
        public string name { get; }

        public string pseudonym { get; }

        public int weight { get; }

        public int heigth { get; }

        public int stojka { get; protected set; }

        public int parter { get; protected set; }

        public string weightCategory { get; protected set; }
        
        public int energy { get; protected set; }

        public int extraEnergy { get; protected set; }
        
        private int contracts = 1;

        public string corner { get; protected set; }

        public Fighter(string name, string pseudonym, int heigth, int weight, int stojka, int parter)
        {
            this.name = name;
            this.pseudonym = pseudonym;
            this.weight = weight;
            this.heigth = heigth;
            this.stojka = stojka ;
            this.parter = parter;
        }

        public void UpgradeStojka(int value)
        {
            stojka += value;
        }

        public void UpgradeParter(int value)
        {
            parter += value;
        }

        public void UpgradeEnergy(int value)
        {
            extraEnergy += value;
        }
        
        public void SetCornerAsPlayer()
        {
            corner = "player";
        }

        public void ResetCorner()
        {
            corner = null;
        }
        
        public void DowngradeContracts()
        {
            contracts -= 1;
        }

        public void UpgradeContracts()
        {
            contracts += 1;
        }

        public int GetContractsNumber()
        {
            return contracts;
        }
        
        public void ResetContracts()
        {
            contracts = 1;
        }

        public void ResetEnergy()
        {
            switch (weightCategory)
            {
                case "lekka":
                    energy = 20 + extraEnergy;
                    break;
                case "polsrednia":
                    energy = 25 + extraEnergy;
                    break;
                case "srednia":
                    energy = 30 + extraEnergy;
                    break;
                case "polciezka":
                    energy = 35 + extraEnergy;
                    break;
                case "ciezka":
                    energy = 40 + extraEnergy;
                    break;
            }
        }
        
        public void ReduceEnergy(int value)
        {
            if (energy < value)
            {
                energy = 0;
            }
            else
            {
                energy -= value;
            }
            

        }
        
        public int GetEnergyValue()
        {
            return energy + extraEnergy;
        }
    }
}
