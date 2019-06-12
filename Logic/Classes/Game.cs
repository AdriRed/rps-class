// <copyright file="Game.cs" company="The Best Company in the world">
// Code designed by AdriRed
// </copyright>

using System;

namespace RPS.Back.Classes
{
    /// <summary>
    /// Represents a Rock, Paper, Scissors - type game.
    /// </summary>
    public class Game
    {
        private static readonly string RoundInfo = "\n{0} - {1} \nWinner: {2}\n{3}\n";

        private Player _Player1;
        private Player _Player2;
        private Score _Score;
        private Round _ActualRound;
        private Logic _Rules;

        /// <summary>
        /// Initializes a new instance of the <see cref="Game"/> class.
        /// Create a game with 2 players and specific rules.
        /// </summary>
        /// <param name="p1">
        /// Sets the Player 1.
        /// </param>
        /// <param name="p2">
        /// Sets the Player 2.
        /// </param>
        /// <param name="rules">
        /// Sets the rules that game will follow.
        /// </param>
        public Game(Player p1, Player p2, Logic rules)
        {
            Console.WriteLine();
            this.Player1 = p1;
            this.Player2 = p2;
            this.Score = new Score(Player1, Player2);
            this.Rules = rules;
        }


        /// <summary>
        /// Gets the Rules of the game.
        /// </summary>
        public Logic Rules
        {
            get { return _Rules; }
            private set { _Rules = value; }
        }

        /// <summary>
        /// Gets the actual round of the game.
        /// </summary>
        public Round ActualRound
        {
            get { return _ActualRound; }
            private set { _ActualRound = value; }
        }

        /// <summary>
        /// Gets the actual score of the game.
        /// </summary>
        public Score Score
        {
            get { return _Score; }
            private set { _Score = value; }
        }

        /// <summary>
        /// Gets the second player.
        /// </summary>
        public Player Player2
        {
            get { return _Player2; }
            private set { _Player2 = value; }
        }

        /// <summary>
        /// Gets the first player
        /// </summary>
        public Player Player1
        {
            get { return _Player1; }
            private set { _Player1 = value; }
        }

        /// <summary>
        /// Gets info of last round: hands, winner and score.
        /// </summary>
        public string LastRoundInfo
        {
            get
            {
                return String.Format(RoundInfo, Player1.Hand, Player2.Hand, ActualRound.Winner, Score.ToString());
            }
        }
        
        /// <summary>
        /// Sets a new round with the moves of each player.
        /// </summary>
        /// <param name="moveP1">
        /// Move of Player 1.
        /// </param>
        /// <param name="moveP2">
        /// Move of Player 2.
        /// </param>
        public void NewRound(string moveP1, string moveP2)
        {
            Player1.Hand = moveP1;
            Player2.Hand = moveP2;

            NewRound();
        }

        /// <summary>
        /// Sets the actual round with players and rules of the game.
        /// </summary>
        public void NewRound()
        {
            ActualRound = new Round(Player1, Player2, Rules);
        }
    }
}
