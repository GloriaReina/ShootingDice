using System;
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer:Player
    {
         public override int Roll()
    {
        // Return a random number in upper half of possible roll (6 sided dice)
        return new Random().Next(4,7);
    }
    }
