using RPS.Back.Objects;
using System.Collections.Generic;

namespace RPS.Back.Interfaces
{
    public interface ILogic
    {
        string GameName { get; }
        List<string> Moves { get; }
        Player GetWinner(Player player1, Player player2);
    }
}
