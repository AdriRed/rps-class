using System;
using System.Collections.Generic;
using System.Text;

namespace RPS.Back.Classes
{
    public abstract class Logic
    {
        private static readonly string _InfoPrompt = "Default Logic";

        /// <summary>
        /// Returns the info of this logic.
        /// </summary>
        public virtual string Info
        {
            get { return _InfoPrompt; }
        }

        /// <summary>
        /// Gets the list of available moves.
        /// </summary>
        public abstract string[] Moves { get; }

        /// <summary>
        /// Returns the winner between 2 players. Returns null when the move of each player are equals.
        /// </summary>
        /// <param name="player1">The first player.</param>
        /// <param name="player2">The second player.</param>
        /// <returns></returns>
        public abstract Player GetWinner(Player player1, Player player2);

        /// <summary>
        /// Returns the condition to win.
        /// </summary>
        /// <param name="player1">The first player.</param>
        /// <param name="player2">The second player.</param>
        /// <returns></returns>
        protected abstract bool GetCondition(Player player1, Player player2);
    }
}
