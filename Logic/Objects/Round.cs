using System;
using System.Collections.Generic;
using System.Text;
using RPS.Interfaces;
using RPS.Logic;

namespace RPS.Objects
{
    public class Round : IRound
    {
        Player P1, P2, Winner;

        public Round(Player p1, Player p2)
        {
            P1 = p1;
            P2 = p2;
        }

        public void SetWinner()
        {
            Winner = Rules.SetWinner(P1, P2);
        }

        public Player GetWinner()
        {
            return Winner;
        }

        public string GetWinnerName()
        {
            return Winner.Name;
        }

        public string GetResult()
        {
            string name;

            if (Winner != null)
            {
                name = Winner.Name;
            }
            else
            {
                name = "TIE";
            }

            return name;
        }

    }
}
