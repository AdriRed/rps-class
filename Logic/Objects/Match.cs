using System;
using System.Collections.Generic;
using System.Text;
using Logic;

namespace RPS.Objects
{
    public class Match
    {
        Player P1, P2, Winner;

        public Match(string p1move, string p2move)
        {
            (P1 = new Player(1)).SetMove(p1move);
            (P2 = new Player(2)).SetMove(p2move);
        }

        public void SetWinner()
        {
            
        }

        public sbyte GetWinner()
        {
            return Winner.GetItem();
        }
    }
}
