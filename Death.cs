using System;

namespace RPG_Game
{
    // The horseman of Death, one of the four horsemen of the apocalypse
    class Death : Statistic
    {
        // Constructor
        public Death(string name, float health, float attackDamage, string magicItem, byte victories = 0, byte losses = 0)
            : base(name, health, attackDamage, magicItem, victories, losses)
        {
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Special title: Horseman of Death");
        }
    }
}