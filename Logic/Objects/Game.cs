using System;

namespace RPS.Objects
{
    public class Game
    {
        private Player Player1, Player2;
        private Score Score;
        private Round ActualRound;

        public string LastRoundInfo
        {
            get
            {
                return Player1.Hand + " - " + Player2.Hand + "\nWinner: " + ActualRound.Winner + "\n" + Score.ToString() + "\n";
            }
        }

        public Game(Player p1, Player p2)
        {
            this.Player1 = p1;
            this.Player2 = p2;
            this.Score = new Score(Player1, Player2);
        }

        public void NewRound(string moveP1, string moveP2)
        {
            Player1.Hand = moveP1;
            Player2.Hand = moveP2;

            NewRound();
        }

        public void NewRound()
        {
            ActualRound = new Round(Player1, Player2);
        }
    }
}
