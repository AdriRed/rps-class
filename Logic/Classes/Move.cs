using RPS.Back.Interfaces;

namespace RPS.Back.Objects
{
    /// <summary>
    /// Represents a Move of a specific <see cref="ILogic">Rules</see>.
    /// </summary>
    public class Move
    {
        private ILogic _Rules;
        private byte _Type;

        /// <summary>
        /// Contains the value of the <see cref="Move"/>.
        /// </summary>
        public byte Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        /// <summary>
        /// Converts the Type of the <see cref="Move"/> to a name specified in <see cref="ILogic"/>.
        /// </summary>
        /// <returns>
        /// Returns the name of the move.
        /// </returns>
        public override string ToString()
        {
            return _Rules.Moves[Type];
        }

        /// <summary>
        /// Sets the Type of <see cref="Move"/> by name.
        /// </summary>
        /// <param name="Rules">The Move follow specific rules.</param>
        /// <param name="typeName">The name of the Move</param>
        public Move(ILogic Rules, string typeName)
        {
            this._Rules = Rules;
            this.Type = (byte)Rules.Moves.IndexOf(typeName);
        }
    }
}
