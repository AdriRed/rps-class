namespace RPS.Objects
{
    public class Game
    {
        private Player P1, P2;
        private Score Score;
        private Round ActualRound;

        public string LastRoundInfo
        {
            get
            {
                return P1.Hand + " - " + P2.Hand + "\nWinner: " + ActualRound.Winner + "\n" + Score.ToString() + "\n";
            }
        }

        public Game(Player p1, Player p2)
        {
            this.P1 = p1;
            this.P2 = p2;
            this.Score = new Score(P1, P2);
        }

        public void NewRound(string moveP1, string moveP2)
        {
            P1.Hand = moveP1;
            P2.Hand = moveP2;

            ActualRound = new Round(P1, P2);
        }
    }
}
