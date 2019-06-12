namespace RPS.Back.Classes
{
    public class Round
    {
        private static readonly string _NoWinner = "TIE";
        private Player _Winner;

        /// <summary>
        /// Returns the name of the Winner of the round or the default message when draw.
        /// </summary>
        public string Winner
        {
            get
            {
                string name;

                name = _Winner != null ? _Winner.Name : _NoWinner;

                return name;
            }
        }

        /// <summary>
        /// Initializes the round with two players and a rules to follow.
        /// </summary>
        /// <param name="p1">The first player.</param>
        /// <param name="p2">The second player.</param>
        /// <param name="Rules">The rules to follow.</param>
        public Round(Player p1, Player p2, Logic Rules)
        {
            _Winner = Rules.GetWinner(p1, p2);
        }
    }
}
