using System;
using System.Linq;
using System.Collections.Generic;
    
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer: Player
{
    public string Taunt { get; }

    public List<string> TauntList = new List<string>();

    public CreativeSmackTalkingPlayer(List<string> tauntList)
    {
        
         Random randomAssignTauntGenerator = new Random();
            int randomTaunt = randomAssignTauntGenerator.Next(0, tauntList.Count);
            
            Taunt= tauntList[randomTaunt];
         
    }

}
