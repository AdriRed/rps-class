using System;
using System.Collections.Generic;

namespace RPS.Objects
{
    public class Move
    {
        private readonly List<string> TYPES = new List<string>{ "Rock", "Paper", "Scissors" };

        public sbyte Type;

        public Move(string typeName)
        {
            Type = (sbyte) TYPES.IndexOf(typeName);
        }

    }
}
