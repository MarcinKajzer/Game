using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer.Fighters.WeightCategories
{
    class Polsrednia : Fighter
    {
        public Polsrednia(string name, string pseudonym, int heigth, int weight, int stojka, int parter)
            : base(name, pseudonym, heigth, weight, stojka, parter)
        {
            weightCategory = "polsrednia";
            energy = 25;
        }
    }
}
