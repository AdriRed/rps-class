using RPS.Back.Objects;
using System.Collections.Generic;

namespace RPS.Back.Interfaces
{
    public interface ILogic
    {
        /// <summary>
        /// Will have the Name of the Game.
        /// </summary>
        string GameName { get; }
        /// <summary>
        /// Will have the list of available names of moves.
        /// </summary>
        List<string> Moves { get; }
        /// <summary>
        /// Calculates the winnner between the <paramref name="player1"> and the <paramref name="player2"/></param>
        /// </summary>
        /// <param name="player1">The first <see cref="Player"/>.</param>
        /// <param name="player2">The second <see cref="Player"/>.</param>
        /// <returns>Returns the <see cref="Player"/> that won the match. Returns null if tie.</returns>
        Player GetWinner(Player player1, Player player2);
    }
}
