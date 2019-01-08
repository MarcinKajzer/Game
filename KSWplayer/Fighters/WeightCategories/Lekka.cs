using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer.Fighters
{
    class Lekka : Fighter
    {
        public Lekka(string name, string pseudonym, int heigth, int weight, int stojka, int parter)
            : base(name, pseudonym, heigth, weight, stojka, parter)
        {
            weightCategory = "lekka";
            energy = 20;
        }
    }
}
