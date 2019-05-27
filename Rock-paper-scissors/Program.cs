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

            Console.Write("Nombre jugador 1: ");
            Player player1 = new Player(Console.ReadLine().Trim());

            Console.Write("Nombre jugador 2: ");
            Player player2 = new Player(Console.ReadLine().Trim());

            Game game = new Game(player1, player2);

            GameRound(player1, player2, game);
            GameRound(player1, player2, game);
            GameRound(player1, player2, game);
            GameRound(player1, player2, game);
            GameRound(player1, player2, game);
            GameRound(player1, player2, game);
            GameRound(player1, player2, game);
            GameRound(player1, player2, game);
            GameRound(player1, player2, game);
            GameRound(player1, player2, game);
        }

        private static void GameRound(Player player1, Player player2, Game game)
        {
            GetMove(player1);
            GetMove(player2);

            game.NewRound();
            Console.WriteLine(game.LastRoundInfo);
        }

        private static void GetMove(Player player)
        {
            const string error = "ERROR";
            bool correct;
            string input;

            do
            {
                Console.Write("Movement of " + player.Name + ": ");
                input = Console.ReadLine().Trim();
                int index = Move.Types.IndexOf(input);
                correct = index > 0;
                if (!correct) Console.WriteLine(error);

            } while (!correct);

            player.Hand = input;
        }
    }
}