using RPS.Objects;
using System;

namespace RPS.Front
{
    class Program
    {
        static void Main()
        {
            //P1 = PLAYER 1
            //P2 = PLAYER 2

            Player player1 = new Player("Adri");
            Player player2 = new Player("Alberto");

            Game game = new Game(player1, player2);

            game.NewRound("Rock", "Rock");
            Console.WriteLine(game.LastRoundInfo);

            game.NewRound("Paper", "Scissors");
            Console.WriteLine(game.LastRoundInfo);

            game.NewRound("Rock", "Paper");
            Console.WriteLine(game.LastRoundInfo);

            game.NewRound("Scissors", "Paper");
            Console.WriteLine(game.LastRoundInfo);

            game.NewRound("Rock", "Rock");
            Console.WriteLine(game.LastRoundInfo);

            game.NewRound("Paper", "Scissors");
            Console.WriteLine(game.LastRoundInfo);

            game.NewRound("Rock", "Scissors");
            Console.WriteLine(game.LastRoundInfo);

            game.NewRound("Paper", "Rock");
            Console.WriteLine(game.LastRoundInfo);



        }

    }
}