using System;
using System.Collections.Generic;
using RPS.Interfaces;
using RPS.Objects;

namespace RPS.Logic
{
    public class Rules
    {

        public static Player SetWinner(Player p1, Player p2)
        {
            Player Winner;

            sbyte p1Movement = p1.Hand.Type;
            sbyte p2Movement = p2.Hand.Type;

            if (p1Movement != p2Movement)
            {
                if ((p2Movement + 1) % 3 == p1Movement)
                {
                    p1.AddPoint();
                    Winner = p1;
                } else
                {
                    p2.AddPoint();
                    Winner = p2;
                }
            } else
            {
                Winner = null;
            }

            return Winner;
        }

    }
}
