using System;
using System.Collections.Generic;
using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {   
            /*----------------------- instantiate players---------------------------------*/

            List<string> tauntArsenalList = new List<string>() {
            "You're making this too easy. It's like you're not even trying!","I'm starting to feel bad for you. It must be tough being so outmatched.","You're playing like a beginner. Maybe you should stick to easier games.","Is that all you've got? I expected more from a player like you!",
            };
            SmackTalkingPlayer playerSmack = new SmackTalkingPlayer ("***Is that all you got punk!***");
            playerSmack.Name = "BigEgo";

            OneHigherPlayer oneHigherPlayer1 = new OneHigherPlayer ();
            oneHigherPlayer1.Name = "OneUpdude";

            HumanPlayer humanPlayer1 = new HumanPlayer ();
            humanPlayer1.Name = "Me";

            CreativeSmackTalkingPlayer creativeSmackTalkingPlayer1= new CreativeSmackTalkingPlayer (tauntArsenalList);
            creativeSmackTalkingPlayer1.Name = "ShxtTalker";

            SoreLoserPlayer soreLoserPlayer1 = new SoreLoserPlayer ();
            soreLoserPlayer1.Name = "SoreLoser";

            UpperHalfPlayer upperHalfPlayer1 = new UpperHalfPlayer ();
            upperHalfPlayer1.Name = "HigherRolls";

           SoreLoserUpperHalfPlayer soreLoserUpperHalfPlayer1 = new SoreLoserUpperHalfPlayer ();
           soreLoserUpperHalfPlayer1.Name = "BadSportHigh";

            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            Player player3 = new Player();
            player3.Name = "Wilma";

            /*------------------------------------------------------------------------------*/

            /*------------- access play method to set up games between players--------------*/
            player2.Play(player1);

            Console.WriteLine("-------------------");

            player3.Play(player2);

            Console.WriteLine("-------------------");

            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");

            playerSmack.Play(large);

            Console.WriteLine("-------------------");

            oneHigherPlayer1.Play(playerSmack);

            Console.WriteLine("-------------------");

            humanPlayer1.Play(player2);

            Console.WriteLine("-------------------");

            creativeSmackTalkingPlayer1.Play(soreLoserUpperHalfPlayer1);

            Console.WriteLine("-------------------");

            soreLoserPlayer1.Play(humanPlayer1);

            Console.WriteLine("-------------------");

            upperHalfPlayer1.Play(player2);

            Console.WriteLine("-------------------");

            soreLoserUpperHalfPlayer1.Play(creativeSmackTalkingPlayer1);

            Console.WriteLine("-------------------");

            
            /*------------------------------------------------------------------------------*/

            //Store players in a list
            List<Player> players = new List<Player>() {
                player1, player2, player3, large, playerSmack, oneHigherPlayer1,humanPlayer1,creativeSmackTalkingPlayer1,soreLoserPlayer1, upperHalfPlayer1, soreLoserUpperHalfPlayer1
            };

            //Call PlayMany method
            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
