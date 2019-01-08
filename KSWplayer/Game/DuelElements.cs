using KSWplayer.Graphics;
using KSWplayer.GraphicsAndAnimations;
using KSWplayer.Verdicts;
using System;
using System.Collections.Generic;
using System.Threading;

namespace KSWplayer
{
    class DuelElements
    {
        public static void Fight(IFighter player, IFighter rival, Queue<Fighter> rivalsQueue )
        {
            RoundVerdict roundVerdict = new RoundVerdict();
            FightVerdictOnPoints fightVerdict = new FightVerdictOnPoints();
            
            string gameStatus = "continues";
            int getVerdictDeterminant = 0; 

            FightHeader.Animation();

            FightersInfo.Compare(player, rival);

            CountingDown.CountBeforeFight();

            Contracts.Display(player);
            
            for (int i = 1; i <= 3; i++)
            {
                RoundHeader.Display(i);
                
                Round(player, rival, i, ref gameStatus, ref roundVerdict);

                if (gameStatus == "Winn")
                {
                    rivalsQueue.Dequeue();
                    break;
                }
                else if (gameStatus == "Loss")
                {
                    break;
                }

                getVerdictDeterminant += 1;
            }

            if (getVerdictDeterminant == 3)
            {
                fightVerdict.GetFightVerdict(roundVerdict, rivalsQueue, player);
            }

        }
        
        public static void Round(IFighter player, IFighter rival, int roundNumber, ref string GameStatus, ref RoundVerdict roundVerdict)
        {
            player.ResetEnergy();
            rival.ResetEnergy();

            int getRoundVerdictDeterminant = 0;

            for (int j = 0; j < 6; j++)
            {
                if (j % 2 == 0)
                {
                    Thread.Sleep(2000);
                    Action(player, rival, roundNumber, ref GameStatus);
                }
                else
                {
                    Thread.Sleep(2000);
                    Action(rival, player, roundNumber, ref GameStatus);
                }

                if (GameStatus == "Winn" || GameStatus == "Loss")
                {
                    break;
                }
                getRoundVerdictDeterminant += 1;
            }
            if( getRoundVerdictDeterminant == 6)
            {
                roundVerdict.GetRoundVerdict(player, rival, roundNumber);
            }
            
            Console.ReadKey();

        }

        static void Action(IFighter fighter_1, IFighter fighter_2, int roundNumber, ref string gameStatus)
        {
            string technique;
            int scoring;

            if (fighter_1.corner == "player")
            {
                Console.Write("  -- Wciśnij wybrany klawisz, aby zaatakować: ");
                ConsoleKeyInfo TechniqueKey = Console.ReadKey();

                Console.WriteLine($"\n\n  Atakuje {fighter_1.name}\n");
                Thread.Sleep(1000);

                Random randomForPlayer = new Random();
                int actionScoringDeterminant = randomForPlayer.Next(4);

                technique = Techniques.GetTechniqueForPlayer(TechniqueKey, actionScoringDeterminant);
                scoring = Techniques.GetScoringForPlayer(TechniqueKey, fighter_1, actionScoringDeterminant);
            }
            else
            {
                Console.Write($"  Atakuje {fighter_1.name}");

                Thread.Sleep(1000); Console.Write(". ");
                Thread.Sleep(1000); Console.Write(". ");
                Thread.Sleep(1000); Console.WriteLine(". ");
                Thread.Sleep(1000); Console.WriteLine();

                Random randomForRival = new Random();
                int scoringAndTechniqueDeterminant = randomForRival.Next(6);

                technique = Techniques.GetRandomTechnique(scoringAndTechniqueDeterminant);
                scoring = Techniques.GetRandomScoring(fighter_1, scoringAndTechniqueDeterminant);
            }
            
            Console.WriteLine($"  {fighter_1.pseudonym} => {technique} => {fighter_2.pseudonym}");
            Thread.Sleep(1000);
            Console.WriteLine($"  Akcja za {scoring}");
            Thread.Sleep(1000);

            if (fighter_2.energy > scoring)
            {
                fighter_2.ReduceEnergy(scoring);
                Console.WriteLine($"  Energia zawodnika - {fighter_2.pseudonym} : {fighter_2.energy}\n");
            }
            else
            {
                fighter_2.ReduceEnergy(1000);
                Console.WriteLine($"  Energia zawodnika - {fighter_2.pseudonym} : {fighter_2.energy}\n");

                FightVerdictBeforeTime.Winn(fighter_1, fighter_2, roundNumber);
                FightVerdictBeforeTime.Loss(fighter_2, roundNumber);
                
                if (fighter_1.corner == "player")
                {
                    gameStatus = "Winn";
                }
                else
                {
                    gameStatus = "Loss";
                }
            }
        }
    }
}
