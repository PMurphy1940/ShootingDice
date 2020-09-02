using System;
using System.Collections.Generic;

namespace ShootingDice {

    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player {

        public List<string> Taunts { get; set; }

        public override int Roll (int opponentRoll) {
            // Return a random number between 1 and DiceSize
            string yoMama = getTaunt ();
            Console.WriteLine (yoMama);
            return new Random ().Next (DiceSize) + 1;
        }
        private string getTaunt () {
            int index = new Random ().Next (0, Taunts.Count);
            return Taunts[index];
        }

    }
}