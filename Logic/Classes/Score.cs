using System;

namespace RPS.Back.Classes
{
    public class Score
    {
        private readonly static string _ScorePrompt = "{0} - {1}";
        private Player _P1, _P2;

        /// <summary>
        /// Initializes the score with 2 players.
        /// </summary>
        /// <param name="p1">The first player.</param>
        /// <param name="p2">The second player.</param>
        public Score(Player p1, Player p2)
        {
            this._P1 = p1;
            this._P2 = p2;
        }

        /// <summary>
        /// Returns the score with the format <see cref="Player.Points">Player1</see> - <see cref="Player.Points">Player2</see>.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format(_ScorePrompt, _P1.Points, _P2.Points);
        }
    }
}