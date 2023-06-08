using System;

    
    // TODO: Complete this class

    // A Player whose roll will always be in the upper half of their possible rolls
    public class UpperHalfPlayer:Player
    {

         public override int Roll()
    {
        // Return a random number in upper half of possible roll (6 sided dice)
        return new Random().Next(4,7);
    }

    }
