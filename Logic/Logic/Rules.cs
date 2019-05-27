using RPS.Objects;

namespace RPS.Logic
{
    public class Rules
    {

        public static Player SetWinner(Player p1, Player p2)
        {
            Player Winner;

            byte p1Movement = p1.HandType;
            byte p2Movement = p2.HandType;

            if (p1Movement != p2Movement)
            {
                if ((p1Movement + 1) % 5 == p2Movement || (p1Movement + 3) % 5 == p2Movement)
                {
                    p1.AddPoint();
                    Winner = p1;
                }
                else
                {
                    p2.AddPoint();
                    Winner = p2;
                }
            }
            else
            {
                Winner = null;
            }

            return Winner;
        }

    }
}
