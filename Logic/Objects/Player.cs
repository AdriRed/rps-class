using RPS.Back.Interfaces;

namespace RPS.Back.Objects
{
    public class Player
    {
        private Move _Hand;
        private ILogic Rules;

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
                _Hand = new Move(Rules, value);
            }
            get
            {
                return _Hand.ToString();
            }
        }

        public uint Points
        {
            private set;
            get;
        }

        public Player(ILogic rules)
        {
            this.Rules = rules;
            this.Name = "PLAYER";
            Points = 0;
        }

        public Player(ILogic rules, string name)
        {
            this.Rules = rules;
            this.Name = name;
            Points = 0;
        }

        public void AddPoint()
        {
            Points++;
        }
    }
}
