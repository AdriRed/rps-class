using System;
using System.Collections.Generic;
using System.Text;
using RPS.Interfaces;

namespace RPS.Objects
{
    public class Game : IGame
    {
        Player P1, P2;
        Score sc;
        public Round actualRound;

        public Game(Player p1, Player p2)
        {
            this.P1 = p1;
            this.P2 = p2;
            this.sc = new Score(P1, P2);
        }

        public void NewRound (string moveP1, string moveP2)
        {
            P1.SetMove(moveP1);
            P2.SetMove(moveP2);
            NewRound(P1, P2);
        }

        

        public string GetState()
        {
            return sc.State();
        }

        public void NewRound(Player p1, Player p2)
        {
            actualRound = new Round(P1, P2);
            actualRound.SetWinner();
        }
    }
}
