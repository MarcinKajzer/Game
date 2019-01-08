using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer
{
    class Instructions
    {
        public static void BeforeGame(IFighter player)
        {

            Console.Clear();
            Console.WriteLine($"\n  Jako {player.name} wkraczasz w progi mieszanych sztuk walki federacj KSW. Przed Tobą cztery walki, które\n  dzielą Cię od mistrzostwa. Aby zdobyć pas, musisz wygrać je wszystkie. " +
                "Każdą przegraną walkę należy stoczyć ponownie,\n  bo w końcu pasy KSW zdobywają tylko mistrzowe. Na początek otrzymujesz jeden kontrakt na walkę z pierwszym\n  przeciwnikem.  " +
                "Każda wygrana walka zapewnia dodatkowy kontrakt, natomiast przegrana odbiera kontrakt\n  z Twojego konta. Zdobywane kontrakty się sumują i będą oznaczone serduszkami." +
                "Przegrana pierwsza walka zeruje Twoją\n  pulę kontraktów, co równoważne jest z zakończeniem turnieju i przegraną. Mierzysz się jedynie z zawodnikami w swojej\n  kategorii wagowej. " +
                "Być może w przyszłości będzie możliwość starcia się we FreeFight'ach, ale tego nie wiedzą jeszcze\n  sami włodaże KSW. Teraz skup się na pokonywaniu kolejnych przeciwników, aby osiągnąć upragnione mistrzostwo.\n" +
                "  Bierz się do roboty !! Powodzenia !");

            Console.WriteLine("\n  Aby walczyć użyj podanych klawiszy: \n");
            Console.WriteLine("  Q - Ręce w stójce");
            Console.WriteLine("  W - Nogi w stójce");
            Console.WriteLine("  E - Kombinacje ciosów w stójce");
            Console.WriteLine("\n  A - Ciosy w parterze");
            Console.WriteLine("  S - Techniki parterowe");
            Console.WriteLine("  D - Kombinacje ciosów w parterze");
            Console.WriteLine("\n  UWAGA!!! Użycie innego przycsku skutkuje losowym wyborem techniki.");

            Console.WriteLine("\n\n\n  -- Uzyj dowolnego klawisza, aby postawić pierwszy krok w drodze o pas KSW.-- ");
            Console.ReadKey();
        }
        
    }
}
