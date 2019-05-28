using System;

namespace RPS.Back.Objects
{
    public class Score
    {
        private readonly static string ScorePrompt = "{0} - {1}";
        private Player P1, P2;

        public Score(Player p1, Player p2)
        {
            this.P1 = p1;
            this.P2 = p2;
        }

        public override string ToString()
        {
            return String.Format(ScorePrompt, P1.Points, P2.Points);
        }
    }
}