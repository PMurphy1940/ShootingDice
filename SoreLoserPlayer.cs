using System;

namespace ShootingDice {
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player {
        public override int Roll (int opponentRoll) {
            // Return a random number between 1 and DiceSize
            int myRoll = new Random ().Next (DiceSize) + 1;
            if (opponentRoll >= myRoll) {
                throw new Exception ("This Sucks!");
            } else {
                return myRoll;
            }
        }
        public override void Play (Player other) {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll (1);
            int otherRoll = other.Roll (myRoll);

            Console.WriteLine ($"{Name} rolls a {myRoll}");

            Console.WriteLine ($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll) {
                Console.WriteLine ($"{Name} Wins!");
            } else if (myRoll < otherRoll) {
                throw new Exception ("I hate this");
            } else {
                // if the rolls are equal it's a tie
                Console.WriteLine ("It's a tie");
            }
        }
    }
}