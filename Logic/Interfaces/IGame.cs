using System;
using System.Collections.Generic;
using System.Text;
using RPS.Objects;

namespace RPS.Interfaces
{
    interface IGame
    {
        void NewRound(string movep1, string movep2);
        string GetState();
        void NewRound(Player p1, Player p2);
    }
}
