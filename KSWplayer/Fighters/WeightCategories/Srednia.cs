using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer.Fighters.WeightCategories
{
    class Srednia : Fighter
    {
        public Srednia(string name, string pseudonym, int heigth, int weight, int stojka, int parter)
            : base(name, pseudonym, heigth, weight, stojka, parter)
        {
            weightCategory = "srednia";
            energy = 30;
        }
    }
}
