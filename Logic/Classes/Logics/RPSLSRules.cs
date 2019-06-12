using RPS.Back.Classes;
using System.Collections.Generic;

namespace RPS.Back.Classes.Logics
{
    public class RPSLSRules : RPSRules
    {
        private static readonly string _GameName = "Rock Paper Scissors Lizard Spock";
        private static readonly string[] MoveList = { "SCISSORS", "PAPER", "ROCK", "LIZARD", "SPOCK" };

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

        protected override bool GetCondition(Player player1, Player player2)
        {
            bool condition;

            bool condition1 = (player1.HandType + 1) % 5 == player2.HandType;
            bool condition2 = (player1.HandType + 3) % 5 == player2.HandType;

            condition = condition1 || condition2;

            return condition;
        }
    }
}
