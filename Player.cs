using System;


public class Player
{
    public string Name { get; set; }
    public int DiceSize { get; set; } = 6;

    public virtual int Roll()
    {
        // Return a random number between 1 and DiceSize
        return new Random().Next(DiceSize) + 1;
    }

    public virtual void Play(Player other)
    {
        // Call roll for "this" object and for the "other" object
        int myRoll = Roll();
        int otherRoll = other.Roll();

        Console.WriteLine($"{Name} rolls a {myRoll}");

        if (this is SmackTalkingPlayer smackTalkingPlayer)
        {
            Console.WriteLine(smackTalkingPlayer.Taunt);
        }

        else if (this is CreativeSmackTalkingPlayer creativeSmackTalkingPlayer)
        {

            Console.WriteLine(creativeSmackTalkingPlayer.Taunt);

        }

        Console.WriteLine($"{other.Name} rolls a {otherRoll}");

        if (this is SoreLoserPlayer soreLoserPlayer)
        {
            while (true)
            {

                try
                {
                    if (myRoll < otherRoll)
                    {

                        throw new Exception("There's no way I lost.");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error: " + ex.Message);
                }
                break;
            }
        }
 else if (this is SoreLoserUpperHalfPlayer soreLoserUpperHalfPlayer)
        {
            while (true)
            {

                try
                {
                    if (myRoll < otherRoll)
                    {

                        throw new Exception("Me Losing! It's imposible.");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error: " + ex.Message);
                }
                break;
            }
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
