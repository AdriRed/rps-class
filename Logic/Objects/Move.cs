using System.Collections.Generic;

namespace RPS.Objects
{
    public class Move
    {
        private readonly List<string> Types = new List<string> { "Scissors", "Paper", "Rock", "Lizard", "Spock" };

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
