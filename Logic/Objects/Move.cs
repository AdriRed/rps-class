using System;
using System.Collections.Generic;

namespace RPS.Objects
{
    public class Move
    {
        private readonly List<string> TYPES = new List<string>{ "Rock", "Paper", "Scissors" };

        public byte Type;

        public Move(string typeName)
        {
            Type = (byte) TYPES.IndexOf(typeName);
        }

        

    }
}
