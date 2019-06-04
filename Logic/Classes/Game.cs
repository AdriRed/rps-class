// <copyright file="Game.cs" company="The Best Company in the world">
// Code designed by AdriRed
// </copyright>

using System;
using RPS.Back.Interfaces;

namespace RPS.Back.Objects
{
    /// <summary>
    /// Represents a Rock, Paper, Scissors - type game.
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Has the format necessary to get the info of the round.
        /// </summary>
        private static readonly string RoundInfo = "\n{0} - {1} \nWinner: {2}\n{3}\n";

        /// <summary>
        /// Has all properties of Player 1.
        /// </summary>
        private Player Player1;
        /// <summary>
        /// Has all properties of Player 2.
        /// </summary>
        private Player Player2;
        /// <summary>
        /// Has the score of the game, that access Player 1 and Player 2 personal score.
        /// </summary>
        private Score _Score;
        /// <summary>
        /// Has all properties of the actual round.
        /// </summary>
        private Round ActualRound;

        /// <summary>
        /// Initializes a new instance of the <see cref="Game"/> class.
        /// Create a game with 2 players and specific rules.
        /// </summary>
        /// <param name="p1">
        /// Initializes the Player 1.
        /// </param>
        /// <param name="p2">
        /// Initializes the Player 2.
        /// </param>
        /// <param name="rules">
        /// Initializes the rules of the game.
        /// </param>
        public Game(Player p1, Player p2, ILogic rules)
        {
            Console.WriteLine();
            this.Player1 = p1;
            this.Player2 = p2;
            this._Score = new Score(Player1, Player2);
            this.Rules = rules;
        }

        /// <summary>
        /// Gets the Rules of the game.
        /// </summary>
        public ILogic Rules { get; private set; }

        /// <summary>
        /// Gets info of last round: hands, winner and score.
        /// </summary>
        public string LastRoundInfo
        {
            get
            {
                return String.Format(RoundInfo, Player1.Hand, Player2.Hand, ActualRound.Winner, _Score.ToString());
            }
        }

        /// <summary>
        /// Sets a new round with the moves moveP1 and moveP2.
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
