namespace RPG_Game{
    class Program
{
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                // Initialize characters
                War warHorseman = new War("War", 150f, 80f, "Sword of Flames");
                Death deathHorseman = new Death("Death", 130f, 75f, "Scythe of Souls");

                // Display initial info
                Console.WriteLine("\n--- Character Information ---");
                warHorseman.DisplayInfo();
                deathHorseman.DisplayInfo();

                bool gameOn = true;
                while (gameOn)
                {
                    Console.WriteLine("\nWho should attack?");
                    Console.WriteLine("1. War attacks Death");
                    Console.WriteLine("2. Death attacks War");
                    Console.Write("Choose an option (1 or 2): ");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        warHorseman.Attack(deathHorseman);
                        if (deathHorseman.Health <= 0)
                        {
                            Console.WriteLine("War wins!");
                            warHorseman.UpdateBattleResult(true);  // War wins
                            deathHorseman.UpdateBattleResult(false); // Death loses
                            gameOn = false; // End the current game
                        }
                    }
                    else if (choice == "2")
                    {
                        deathHorseman.Attack(warHorseman);
                        if (warHorseman.Health <= 0)
                        {
                            Console.WriteLine("Death wins!");
                            deathHorseman.UpdateBattleResult(true);  // Death wins
                            warHorseman.UpdateBattleResult(false); // War loses
                            gameOn = false; // End the current game
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice! Please select 1 or 2.");
                    }

                    if (gameOn)
                    {
                        // Display health after each attack
                        Console.WriteLine("\n--- Current Stats ---");
                        warHorseman.DisplayInfo();
                        deathHorseman.DisplayInfo();
                    }
                }

                // Display final stats
                Console.WriteLine("\n--- Final Stats ---");
                warHorseman.DisplayInfo();
                deathHorseman.DisplayInfo();

                // Ask if the player wants to play again
                Console.WriteLine("\nDo you want to play another game? (y/n)");
                string playAgainChoice = Console.ReadLine();
                if (playAgainChoice.ToLower() != "y")
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thank you for playing!");
        }
    }
    }

