using System;
using System.Collections.Generic;
using System.Text;

namespace RPS.Objects
{
    public class Player
    {
        Move Hand;
        private uint score;
        public Player(string move)
        {
            Hand = new Move(move);
        }
    }
}
