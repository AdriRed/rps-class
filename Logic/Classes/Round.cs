using RPS.Back.Interfaces;

namespace RPS.Back.Objects
{
    public class Round
    {
        private static string NoWinner = "TIE";
        private Player _Winner;

        public string Winner
        {
            get
            {
                string name;

                name = _Winner != null ? _Winner.Name : NoWinner;

                return name;
            }
        }

        public Round(Player p1, Player p2, ILogic Rules)
        {
            _Winner = Rules.GetWinner(p1, p2);
        }
    }
}
