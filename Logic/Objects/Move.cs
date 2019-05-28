using RPS.Back.Interfaces;

namespace RPS.Back.Objects
{
    public class Move
    {
        ILogic Rules;

        public byte Type
        {
            set; get;
        }

        public override string ToString()
        {
            return Rules.Moves[Type];
        }

        public Move(ILogic Rules, string typeName)
        {
            this.Rules = Rules;
            this.Type = (byte)Rules.Moves.IndexOf(typeName);
        }

    }
}
