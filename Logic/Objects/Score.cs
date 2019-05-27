namespace RPS.Objects
{
    public class Score
    {
        private Player P1, P2;

        public Score(Player p1, Player p2)
        {
            this.P1 = p1;
            this.P2 = p2;
        }

        public override string ToString()
        {
            return P1.Points + " - " + P2.Points;
        }
    }
}