using System;
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer: Player
    {
        public string Prompt { get; }

         public override void Play(Player other)
    {
        // Call roll for "this" object and for the "other" object
        int myRoll = Roll();
        int otherRoll = other.Roll();

        if (this is HumanPlayer humanPlayer)
        {
            Console.Write($"{other.Name} for you roll, enter a number:");
            otherRoll= int.Parse(Console.ReadLine());
            Console.WriteLine($"{Name} rolls a {myRoll}");
            
        }
        

        if (myRoll > otherRoll)
        {
            Console.WriteLine($"{Name} Wins!");
        }
        else if (myRoll < otherRoll)
        {
            Console.WriteLine($"{other.Name} Wins!");
        }
        else
        {
            // if the rolls are equal it's a tie
            Console.WriteLine("It's a tie");
        }
    }
    }

