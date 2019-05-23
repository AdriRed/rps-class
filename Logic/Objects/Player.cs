using System;
using System.Collections.Generic;
using System.Text;

namespace RPS.Objects
{
    public class Player
    {
        string name;
        public Move Hand;
        sbyte annexedItem;
        private uint score;


        public Player(sbyte annexedItem)
        {
            this.annexedItem = annexedItem;
            name = "PLAYER " + annexedItem;
            score = 0;
        }

        public Player(sbyte annexedItem, string name)
        {
            this.annexedItem = annexedItem;
            this.name = name;
            score = 0;
        }

        public void SetMove(string move)
        {
            Hand = new Move(move);
        }

        public void AddPoint()
        {
            score++;
        }

        public sbyte GetItem()
        {
            return annexedItem;
        }

    }
}
