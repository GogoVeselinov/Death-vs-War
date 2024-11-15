namespace RPG_Game{
        class Statistic : Character
    {
        // Private fields
        private byte _victories;
        private byte _losses;
        private byte _totalGames;

        // Constructor with statistics
        public Statistic(string name, float health, float attackDamage, string magicItem, byte victories = 0, byte losses = 0)
            : base(name, health, attackDamage, magicItem)
        {
            _victories = victories;
            _losses = losses;
            _totalGames = (byte)(victories + losses);
        }

        // Properties for victories and losses
        public byte Victories
        {
            get { return _victories; }
            set
            {
                _victories = value;
                UpdateTotalGames();
            }
        }

        public byte Losses
        {
            get { return _losses; }
            set
            {
                _losses = value;
                UpdateTotalGames();
            }
        }

        public byte TotalGames => _totalGames;

        // Method to update total games
        private void UpdateTotalGames()
        {
            _totalGames = (byte)(_victories + _losses);
        }

        // Display character and statistics information
        public virtual void DisplayInfo()
        {
            Console.WriteLine("\nCharacter Information:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: {Health:F2}");
            Console.WriteLine($"Attack Damage: {AttackDamage:F2}");
            Console.WriteLine($"Magic Item: {MagicItem}");
            Console.WriteLine($"Wins: {Victories}");
            Console.WriteLine($"Losses: {Losses}");
            Console.WriteLine($"Total Games: {TotalGames}");
        }

        // Update victory or loss based on battle outcome
        public void UpdateBattleResult(bool victory)
        {
            if (true)
            {
                Victories++;
            }
            else
            {
                Losses++;
            }
        }
    }
}