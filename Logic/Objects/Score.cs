using System;
using RPS.Interfaces;

namespace RPS.Objects
{
    public class Score : IScore
    {

        Player P1, P2;

        public Score(Player p1, Player p2)
        {
            this.P1 = p1;
            this.P2 = p2;
        }

        public string State()
        {
            return P1.Score + " - " + P2.Score;
        }
    }
}