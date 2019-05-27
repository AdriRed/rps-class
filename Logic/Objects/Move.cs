﻿using System.Collections.Generic;

namespace RPS.Objects
{
    public class Move
    {
        public static readonly List<string> Types = new List<string> { "Rock", "Paper", "Scissors" };

        public byte Type
        {
            set;
            get;
        }

        public override string ToString()
        {
            return Types[Type];
        }

        public Move(string typeName)
        {
            this.Type = (byte)Types.IndexOf(typeName);
        }

    }
}
