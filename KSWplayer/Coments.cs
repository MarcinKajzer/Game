using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer
{
    class Coments
    {
        static string[] EndingWinnComents = new string[] {  "\n  Brawo !!!. Po tej akcji przeciwnik nie miał żadnych szans",
                                                            "\n  Nikt nie miałby szans na przetrwanie czegoś takiego",
                                                            "\n  Bez dwóch zdań to jest zasłużona wygrana.",
                                                            "\n  Brawo !!! Cóż za spektakularne zakończenie walki.",
                                                            "\n  Publika od początku była po Twojej stornie.",
                                                            "\n  Mistrz pozostaje mistrzem",
                                                            "\n  Brawo !!! Nie bez powodu od początku byłeś faworytem tej walki.",
                                                            "\n  Wielkie Brawa !!! Takiego zakończenia spodziewali się wszyscy.",
                                                            "\n  Zaskakujące zwycięstwo !!! Takiego zakończenia nikt się nie spodziewał.",
                                                            "\n  Brawoo !!! Faworyt został pokonany." };

        static string[] EndingLossComents = new string[] { "\n  Niestety. Po tej akcji nie miałeś żadnych szans",
                                                           "\n  Niestety. Czasem nawet najlepsi muszą ustąpić miejsca kolejnym, być może młodszym wyjadaczonm",
                                                           "\n  Zaskakująca porażka. Widownia oniemiała",
                                                           "\n  Przegrana. Rywal może być z siebie dumny",
                                                           "\n  No nieistety. Tym razem wrócisz do domu na tarczy.",
                                                           "\n  A jednak przegrana. Czasem do samego końca nie wiadomo czego się spodziewać."};

        public static string Winn()
        {
            Random random = new Random();

            int index = random.Next(EndingWinnComents.Length);

            string Comment = EndingWinnComents[index];
            
            return Comment;
        }

        public static string Loss()
        {
            Random random = new Random();

            int index = random.Next(EndingLossComents.Length);

            string Comment = EndingLossComents[index];

            return Comment;
        }
    }
}
