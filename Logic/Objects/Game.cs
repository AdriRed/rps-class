using RPS.Back.Interfaces;
using System;

namespace RPS.Back.Objects
{
    public class Game
    {
        private static readonly string RoundInfo = "\n{0} - {1} \nWinner: {2}\n{3}\n";
        private Player Player1, Player2;
        private Score _Score;
        private Round ActualRound;

        public ILogic Rules { get; private set; }

        public string LastRoundInfo
        {
            get
            {
                return String.Format(RoundInfo, Player1.Hand, Player2.Hand, ActualRound.Winner, _Score.ToString());
            }
        }

        public Game(Player p1, Player p2, ILogic rules)
        {
            Console.WriteLine();
            this.Player1 = p1;
            this.Player2 = p2;
            this._Score = new Score(Player1, Player2);
            this.Rules = rules;
        }

        public void NewRound(string moveP1, string moveP2, ILogic Rules)
        {
            Player1.Hand = moveP1;
            Player2.Hand = moveP2;

            NewRound(Rules);
        }

        public void NewRound(ILogic Rules)
        {
            ActualRound = new Round(Player1, Player2, Rules);
        }
    }
}
