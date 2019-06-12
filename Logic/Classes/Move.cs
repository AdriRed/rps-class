// <copyright file="Move.cs" company="The Best Company in the world">
// Code designed by AdriRed
// </copyright>
using System;

namespace RPS.Back.Classes
{
    /// <summary>
    /// Represents a Move of a specific <see cref="Logic">Rules</see>.
    /// </summary>
    public class Move
    {
        private Logic _Rules;
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
        /// Converts the Type of the <see cref="Move"/> to a name specified in <see cref="Logic"/>.
        /// </summary>
        /// <returns>
        /// Returns the name of the move.
        /// </returns>
        public override string ToString()
        {
            return _Rules.Moves[Type];
        }

        /// <summary>
        /// Initializes the type of <see cref="Move"/> by name.
        /// </summary>
        /// <param name="Rules">The Move follow specific rules.</param>
        /// <param name="typeName">The name of the Move</param>
        public Move(Logic Rules, string typeName)
        {
            this._Rules = Rules;
            this.Type = (byte) Array.IndexOf(Rules.Moves, typeName);
        }
    }
}
