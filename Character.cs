using System;

namespace RPG_Game
{
    class Character
    {
        static Random rnd = new Random();
        private string _name;
        private float _health;
        private float _attackdamage;
        private string _magicitem;

        public Character() { }

        public Character(string Name, float Health, float AttackDamage, string MagicItem)
        {
            this._name = Name;
            this._health = Health;
            this._attackdamage = rnd.Next(50, 100);
            this._magicitem = MagicItem;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public float Health
        {
            get { return _health; }
            set
            {
                // Ensure health doesn't go below 0
                _health = value < 0 ? 0 : value;
            }
        }
        public float AttackDamage
        {
            get { return _attackdamage; }
            set { _attackdamage = value; }
        }

        public string MagicItem
        {
            get { return _magicitem; }
            set { _magicitem = value; }
        }

        public void Attack(Character target)
        {
            if (target == null)
            {
                throw new ArgumentNullException(nameof(target), "Target cannot be null.");
            }

            Console.WriteLine($"{this.Name} attacks {target.Name} for {this.AttackDamage} damage.");
            target.Health -= this.AttackDamage;

            if (target.Health == 0)
            {
                Console.WriteLine($"{target.Name} has been defeated!");
            }
            else
            {
                Console.WriteLine($"{target.Name} has {target.Health} health remaining.");
            }
        }
    }
}
