using RPS.Back.Interfaces;
using RPS.Back.Objects;
using System.Collections.Generic;

namespace RPS.Back.Logic
{
    public class RPSLSRules : ILogic
    {
        internal static readonly string _GameName = "Rock Paper Scissors Lizard Spock";
        internal static readonly List<string> MoveList = new List<string> { "SCISSORS", "PAPER", "ROCK", "LIZARD", "SPOCK" };

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

        public RPSLSRules()
        {

        }

        /*
            Scissors    > Paper, Lizard     -->     0 > 1 , 3
            Paper       > Rock, Spock       -->     1 > 2 , 4
            Rock        > Lizard, Scissors  -->     2 > 3 , 0
            Lizard      > Spock, Paper      -->     3 > 4 , 1
            Spock       > Scissors, Rock    -->     4 > 0 , 2
            
            ...

            x > ( x + 1 ) % 5 , ( x + 3 ) % 5
            
            ...

            Player 1 = x
            Player 2 = y

            if ( x != y )
                if ( x + 1 ) % 5 == y or ( x + 3 ) % 5 == y then
                    winner = Player 1
                else 
                    winner = Player 2
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
                if ((player1.HandType + 1) % 5 == player2.HandType || (player1.HandType + 3) % 5 == player2.HandType)
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
