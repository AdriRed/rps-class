using RPS.Back.Interfaces;
using RPS.Back.Objects;
using System.Collections.Generic;

namespace RPS.Back.Logic
{
    public class RPSRules : ILogic
    {
        internal static readonly string _GameName = "Rock Paper Scissors";
        internal static readonly List<string> MoveList = new List<string> { "ROCK", "PAPER", "SCISSORS" };

        public List<string> Moves
        {
            get
            {
                return MoveList;
            }
        }

        public string GameName
        {
            get
            {
                return _GameName;
            }
        }

        /*
            Rock        > Scissors  -->     0 > 2
            Paper       > Rock      -->     1 > 0
            Scissors    > Paper     -->     2 > 1
            
            ...

            x > ( x + 2 ) % 3
            
            ...

            Player 1 = x
            Player 2 = y

            if ( x != y )
                if ( x + 2 ) % 3 == y then
                    winner = Player 2
                else 
                    winner = Player 1
                end if
            else
                winner = null
            end if
        */

        public Player GetWinner(Player player1, Player player2)
        {
            Player winner;

            if (player1.HandType != player2.HandType)
            {
                if ((player2.HandType + 1) % 3 == player1.HandType)
                {
                    player1.AddPoint();
                    winner = player1;
                }
                else
                {
                    player2.AddPoint();
                    winner = player2;
                }
            }
            else
            {
                winner = null;
            }
            return winner;
        }
    }
}
