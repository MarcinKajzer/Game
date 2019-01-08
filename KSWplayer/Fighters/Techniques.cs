using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSWplayer
{
    class Techniques
    {
        static Random random = new Random();

        static string[] stojkaRece = new string[] { "supermann", "lewy sierpowy", "lewy prosty", "lewy podbródkowy", "prawy sierpowy", "prawy prosty", "prawy podbródkowy" };

        public static string[] stojkaNogi = new string[] { "latające kolano", "opadające kopnęcie","lewy low kick", "prawy low kick", "lewy middlekick", "prawy midlekick", "lewy highkick", "prawy highkick", "kolano na głowę", "kolano na brzuch", "kolano na udo" };

        static string[] parter = new string[] { "parter: lewy na głowe", "parter: prawy na głowe", "parter: lewy na żebra ", "parter: prawy na żebra", "parter: cios na brzuch", "parter: kolano na żebra" };

        static string[] parterTechniki = new string[] { "próba balachy", "trójkąt nogami", "próba kimury", "dosiad", "pozycja boczna", "próba gilotyny","skrętówka na nogę" };
        
        public static string GetCombinationStojka(int numberOfTechniques)
        {
            string combo = "";

            for (int i= 1; i <= numberOfTechniques ; i++)
            {
                if (i == numberOfTechniques)
                {
                    combo += stojkaNogi[random.Next(stojkaNogi.Length)];
                }
                else
                {
                    combo += stojkaRece[random.Next(stojkaRece.Length)]+", ";
                }
            }
            return combo;
        }

        public static string GetCombinationParter(int numberOfTechniques)
        {
            string combo = "";

            for (int i = 1; i <= numberOfTechniques; i++)
            {
                if (i == 3)
                {
                    combo += parterTechniki[random.Next(parterTechniki.Length)];
                }
                else
                {
                    combo += parter[random.Next(parter.Length)] + ", ";
                }
            }
            return combo;
        }
        
        public static string GetRandomTechnique(int determinant)
        {
            switch (determinant)
            {
                case 0:
                    int index_0 = random.Next(stojkaNogi.Length);
                    return stojkaNogi[index_0];
                case 1:
                    int index_1 = random.Next(stojkaRece.Length);
                    return stojkaRece[index_1];
                case 2:
                    int index_2 = random.Next(parter.Length);
                    return parter[index_2];
                case 3:
                    int index_3 = random.Next(parterTechniki.Length);
                    return parterTechniki[index_3];
                case 4:
                    int determinant_E = random.Next(2) + 2;
                    return GetCombinationStojka(determinant_E);
                case 5:
                    int determinant_D = random.Next(2) + 2;
                    return GetCombinationParter(determinant_D);
                default:
                    return "lewy prosty, prawy sierp";
            }
        }

        public static int GetRandomScoring(IFighter Fighter, int determinant)
        {
            switch (determinant)
            {
                case 0:
                case 1:
                    int actionScoring_W = random.Next(Fighter.stojka);
                    return actionScoring_W;
                case 2:
                case 3:
                    int actionScoring_S = random.Next(Fighter.stojka);
                    return actionScoring_S;
                default:
                    return 0;
            }
        }
        // ------------ tutaj był pomysł aby te metody połączyć w jedną GetActionAndScorring, która zwracałaby obiekt klasy ActoioAndScorring
        //zawierający pola string Action i int Scorring - lepsze to, czy 2 osobne metody ? 

        public static int GetScoringForPlayer(ConsoleKeyInfo klawisz, IFighter Fighter, int determinant)
        {
            switch (klawisz.Key)
            {
                case ConsoleKey.Q:
                case ConsoleKey.W:
                case ConsoleKey.E:

                    int actionScoring_QWE = random.Next(Fighter.stojka);
                    return actionScoring_QWE;

                case ConsoleKey.A:
                case ConsoleKey.S:
                case ConsoleKey.D:

                    int actionScoring_ASD = random.Next(Fighter.stojka);
                    return actionScoring_ASD;

                default:
                    return GetRandomScoring(Fighter,determinant);
            }
        }
        
        public static string GetTechniqueForPlayer(ConsoleKeyInfo button, int determinant)
        {
            switch (button.Key)
            {
                case ConsoleKey.Q:
                    int index_Q = random.Next(stojkaRece.Length);
                    return stojkaRece[index_Q];
                case ConsoleKey.W:
                    int index_W = random.Next(stojkaNogi.Length);
                    return stojkaNogi[index_W];
                case ConsoleKey.A:
                    int index_A = random.Next(parter.Length);
                    return parter[index_A];
                case ConsoleKey.S:
                    int index_S = random.Next(parterTechniki.Length);
                    return parterTechniki[index_S];
                case ConsoleKey.E:
                    int determinant_E = random.Next(2) + 2;
                    return GetCombinationStojka(determinant_E);
                case ConsoleKey.D:
                    int determinant_D = random.Next(2) + 2;
                    return GetCombinationParter(determinant_D);
                default:
                    return GetRandomTechnique(determinant);
            }
        }
    }
}

