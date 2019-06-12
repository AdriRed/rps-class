namespace RPS.Back.Classes
{
    public class Player
    {
        private Move _Hand;
        private Logic _Rules;
        private uint _Points;
        private string _Name;

        /// <summary>
        /// Gets the rules that this game are following.
        /// </summary>
        public Logic Rules
        {
            get { return _Rules; }
            private set { _Rules = value; }
        }

        /// <summary>
        /// Sets or gets the name of the player.
        /// </summary>
        public string Name
        {
            set
            {
                _Name = value;
            }
            get
            {
                return _Name;
            }
        }

        /// <summary>
        /// Sets or gets the type (number) of the player's move.
        /// </summary>
        public byte HandType
        {
            set
            {
                _Hand.Type = value;
            }
            get
            {
                return _Hand.Type;
            }
        }

        /// <summary>
        /// Sets or gets the name of the player's move.
        /// </summary>
        public string Hand
        {
            set
            {
                _Hand = new Move(Rules, value);
            }
            get
            {
                return _Hand.ToString();
            }
        }

        /// <summary>
        /// Gets the personal score of the player.
        /// </summary>
        public uint Points
        {
            private set
            {
                _Points = value;
            }
            get
            {
                return _Points;
            }
        }

        /// <summary>
        /// Initializes a game with a rules to follow and a name.
        /// </summary>
        /// <param name="rules">The rules to follow.</param>
        /// <param name="name">The name of the player ("Player" by default).</param>
        public Player(Logic rules, string name = "Player")
        {
            this.Rules = rules;
            this.Name = name;
            Points = 0;
        }

        /// <summary>
        /// +1 to this player.
        /// </summary>
        public void AddPoint()
        {
            Points++;
        }
    }
}
