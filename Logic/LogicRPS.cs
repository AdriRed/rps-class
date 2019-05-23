using System;
using System.Collections.Generic;
using Logic.Interfaces;

namespace Logic
{
    public class LogicRPS : ILogic
    {
        private readonly List<byte> plays;
        private const string X = "Rock", Y = "Paper", Z = "Scissors";
        private readonly byte[] POSSIBLEPLAYS = { 0, 1, 2 };
        private readonly string[] STRINGPLAYS = { X, Y, Z };
        private readonly byte p1Item = 1, p2Item = 2, tieItem = 0;
        private readonly string p1name = "PLAYER 1", p2name = "PLAYER 2", tiename = "TIE";

        public LogicRPS()
        {
            this.plays = new List<byte>();
        }

        public void GetLastMatchWinner()
        {
            throw new NotImplementedException();
        }

        public void GetTotalWinner()
        {
            int p1Victories = 0, p2Victories = 0;

            foreach (byte result in plays)
            {
                if (result == p1Item)
                {
                    p1Victories++;
                } else if (result == p2Item)
                {
                    p2Victories++;
                }
            }

            PrintTotalWinner(p1Victories, p2Victories);
        }

        private void PrintTotalWinner(int p1Victories, int p2Victories)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine(p1Victories + " - " + p2Victories);
        }

        public void Play(byte p1Play, byte p2Play)
        {
            byte winner;

            Console.WriteLine(Traduct(p1Play) + " --- " + Traduct(p2Play));
            
            winner = SetWinner(p1Play, p2Play);
            
            plays.Add(winner);
            PrintWinner(winner);
            Console.WriteLine();
        }

        public void Play(string param1, string param2)
        {
            byte play1, play2;

            play1 = Traduct(param1);
            play2 = Traduct(param2);

            if ((play1 == 4 || play2 == 4))
            {
                Console.WriteLine("ERROR HAND NOT FOUND");
            } else
            {
                Play(play1, play2);
            }

        }

        public void PrintWinner(byte winner)
        {
            if (winner == tieItem)
            {
                Console.WriteLine(tiename);
            } else
            {
                if (winner == p1Item)
                {
                    Console.WriteLine(p1name);
                } else
                {
                    Console.WriteLine(p2name);
                }
            }
        }

        public byte Traduct(string play)
        {
            byte traductedPlay = 4;
            bool found = false;

            for (int i = 0; i < STRINGPLAYS.Length && !found; i++)
            {
                if ( play.Equals(STRINGPLAYS[i], StringComparison.OrdinalIgnoreCase) )
                {
                    traductedPlay = POSSIBLEPLAYS[i];
                    found = true;
                }
            }

            return traductedPlay;
        }

        public string Traduct(byte play)
        {
            return STRINGPLAYS[play];
        }

        public byte SetWinner(byte p1, byte p2)
        {
            byte winner = tieItem;

            if (p1 != p2)
            {
                if ((p2 + 1) % 3 == p1)
                {
                    winner = p1Item;
                } else
                {
                    winner = p2Item;
                }
            }

            return winner;
        }
    }
}
