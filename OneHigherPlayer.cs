using System;

namespace ShootingDice {
    // TODO: Complete this class

    // A Player who always roles one higher than the other player
    public class OneHigherPlayer : Player {
        public override int Roll (int opponentRoll) {

            return opponentRoll + 1;
        }

        public override void Play (Player other) {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll (1);
            int otherRoll = other.Roll (myRoll);
            myRoll = otherRoll + 1;
            Console.WriteLine ($"{Name} rolls a {myRoll}");

            Console.WriteLine ($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll) {
                Console.WriteLine ($"{Name} Wins!");
            } else if (myRoll < otherRoll) {
                Console.WriteLine ($"{other.Name} Wins!");
            } else {
                // if the rolls are equal it's a tie
                Console.WriteLine ("It's a tie");
            }
        }
    }
}