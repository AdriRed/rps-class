using RPS.Back.Classes;
using System.Collections.Generic;

namespace RPS.Back.Classes.Logics
{
    public class RPSRules : Logic
    {
        private static readonly string _GameName = "Rock Paper Scissors";
        private static readonly string[] MoveList = { "ROCK", "PAPER", "SCISSORS" };

        public override string[] Moves
        {
            get
            {
                return MoveList;
            }
        }


        public override string Info
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

        public override Player GetWinner(Player player1, Player player2)
        {
            Player winner;

            if (player1.HandType != player2.HandType)
            {
                if (GetCondition(player1, player2))
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

        protected override bool GetCondition(Player player1, Player player2)
        {
            bool condition;

            condition = (player2.HandType + 1) % 3 == player1.HandType;

            return condition;
        }
    }
}
