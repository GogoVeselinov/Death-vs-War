using System;

namespace RPG_Game
{
    // The horseman of War, one of the four horsemen of the apocalypse
    class War : Statistic
    {
        // Constructor
        public War(string name, float health, float attackDamage, string magicItem, byte victories = 0, byte losses = 0)
            : base(name, health, attackDamage, magicItem, victories, losses)
        {

        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Special title: Horseman of War");
        }
    }

}
