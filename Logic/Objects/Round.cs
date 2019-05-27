using RPS.Logic;

namespace RPS.Objects
{
    public class Round
    {
        private Player _Winner;

        public string Winner
        {
            get
            {
                string name;

                if (_Winner != null)
                {
                    name = _Winner.Name;
                }
                else
                {
                    name = "TIE";
                }

                return name;
            }
        }

        public Round(Player p1, Player p2)
        {
            _Winner = Rules.SetWinner(p1, p2);
        }
    }
}
