using System;
using RPS.Back.Classes;
using RPS.Back.Classes.Logics;

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
            Logic rules;
            Player player1, player2;
            Game game;
            
            rules = new RPSRules();
            RulesInfo(rules);
            player1 = CreatePlayer(Player1Prompt, rules);
            player2 = CreatePlayer(Player2Prompt, rules);
            game = new Game(player1, player2, rules);

            for (int i = 0; i < 10; i++)
            {
                NewRound(player1, player2, game);
            }
            

            rules = new RPSLSRules();
            RulesInfo(rules);

            player1 = CreatePlayer(Player1Prompt, rules);
            player2 = CreatePlayer(Player2Prompt, rules);
            game = new Game(player1, player2, rules);

            for (int i = 0; i < 10; i++)
            {
                NewRound(player1, player2, game);
            }
        }

        private static void RulesInfo(Logic rules)
        {
            Console.WriteLine(String.Format(IntroPrompt, rules.Info));
        }

        private static Player CreatePlayer(string prompt, Logic rules)
        {
            Console.Write(prompt);
            Player player = new Player(rules, Console.ReadLine().Trim());

            return player;
        }

        private static void NewRound(Player player1, Player player2, Game game)
        {
            GetMove(player1, game.Rules);
            GetMove(player2, game.Rules);

            game.NewRound();
            Console.WriteLine(game.LastRoundInfo);
        }

        private static void GetMove(Player player, Logic rules)
        {
            bool correct;
            string input;

            do
            {
                Console.Write(String.Format(AskMovePrompt, player.Name));
                input = Console.ReadLine().Trim().ToUpper();
                int index = Array.IndexOf(rules.Moves, input);
                correct = index >= 0;
                if (!correct) Console.WriteLine(ErrorPrompt);

            } while (!correct);

            player.Hand = input;
        }
    }
}