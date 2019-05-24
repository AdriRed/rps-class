using System;
using System.Collections.Generic;
using System.Text;
using RPS.Interfaces;

namespace RPS.Objects
{
    public class Player : IPlayer
    {
        public string Name;
        public Move Hand;
        public uint Score;


        public Player()
        {
            Score = 0;
            Name = "PLAYER";
        }

        public Player(string name)
        {
            this.Name = name;
            Score = 0;
        }

        public void SetMove(string move)
        {
            Hand = new Move(move);
        }

        public void AddPoint()
        {
            Score++;
        }

        public void SetMove(sbyte move)
        {
            Hand = new Move(move);
        }
    }
}
