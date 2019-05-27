namespace RPS.Objects
{
    public class Player
    {
        private Move _Hand;
        
        public string Name
        {
            set;
            get;
        }

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

        public string Hand
        {
            set
            {
                _Hand = new Move(value);
            }
            get
            {
                return _Hand.ToString();
            }
        }

        

        public uint Points
        {
            set;
            get;
        }

        public Player()
        {
            this.Name = "PLAYER";
            Points = 0;
        }

        public Player(string name)
        {
            this.Name = name;
            Points = 0;
        }

        public void AddPoint()
        {
            Points++;
        }
    }
}
