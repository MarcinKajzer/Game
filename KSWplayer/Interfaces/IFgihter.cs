using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer
{
    interface IFighter
    {
        string name { get; }

        string pseudonym { get; }

        int weight { get; }

        int heigth { get; }

        int stojka { get; }

        int parter { get; }

        string weightCategory { get;}

        int energy { get;  }

        int extraEnergy { get; }
        
        string corner { get;}

        
        void UpgradeStojka(int value);
        
        void UpgradeParter(int value);
        
        void UpgradeEnergy(int value);

        void ReduceEnergy(int value);
        
        void SetCornerAsPlayer();
        
        void ResetCorner();
        
        void DowngradeContracts();
        
        void UpgradeContracts();
        
        int GetContractsNumber();

        void ResetContracts();

        void ResetEnergy();

        int GetEnergyValue();


    }
}
