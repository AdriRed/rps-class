using RPS.Back.Interfaces;
using RPS.Back.Logic;
using RPS.Back.Objects;
using System;

namespace RPS.Front
{
    class Program
    {
        private const string IntroPrompt = "Playing {0}\n";
        private const string Scissors = "Scissors", Paper = "Paper", Rock = "Rock", Lizard = "Lizard", Spock = "Spock";
        private const string Player1Prompt = "Player 1 name: ", Player2Prompt = "Player 2 name: ";
        private const string ErrorPrompt = "ERROR", AskMovePrompt = "Movement of {0}: ";

        static void Main()
        {
            ILogic rules;
            Player player1, player2;
            Game game;

            rules = new RPSRules();
            RulesInfo(rules);

            player1 = PlayerCreation(Player1Prompt, rules);
            player2 = PlayerCreation(Player2Prompt, rules);
            game = new Game(player1, player2, rules);

            for (int i = 0; i < 5; i++)
            {
                GameRound(player1, player2, game);
            }

            rules = new RPSLSRules();
            RulesInfo(rules);

            player1 = PlayerCreation(Player1Prompt, rules);
            player2 = PlayerCreation(Player2Prompt, rules);
            game = new Game(player1, player2, rules);

            for (int i = 0; i < 5; i++)
            {
                GameRound(player1, player2, game);
            }
        }

        private static void RulesInfo(ILogic rules)
        {
            Console.WriteLine(String.Format(IntroPrompt, rules.GameName));
        }

        private static Player PlayerCreation(string prompt, ILogic rules)
        {
            Console.Write(prompt);
            Player player = new Player(rules, Console.ReadLine().Trim());

            return player;
        }

        private static void GameRound(Player player1, Player player2, Game game)
        {
            GetMove(player1, game.Rules);
            GetMove(player2, game.Rules);

            game.NewRound(game.Rules);
            Console.WriteLine(game.LastRoundInfo);
        }

        private static void GetMove(Player player, ILogic rules)
        {
            bool correct;
            string input;

            do
            {
                Console.Write(String.Format(AskMovePrompt, player.Name));
                input = Console.ReadLine().Trim().ToUpper();
                int index = rules.Moves.IndexOf(input);
                correct = index >= 0;
                if (!correct) Console.WriteLine(ErrorPrompt);

            } while (!correct);

            player.Hand = input;
        }
    }
}