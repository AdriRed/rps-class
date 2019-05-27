using RPS.Objects;
using System;

namespace RPS.Front
{
    class Program
    {

        private static string Scissors = "Scissors", Paper = "Paper", Rock = "Rock", Lizard = "Lizard", Spock = "Spock";
        static void Main()
        {
            //P1 = PLAYER 1
            //P2 = PLAYER 2

            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            Game game = new Game(player1, player2);

            game.NewRound(Console.ReadLine().Trim(), Console.ReadLine().Trim());
            Console.WriteLine(game.LastRoundInfo);

        }

    }
}