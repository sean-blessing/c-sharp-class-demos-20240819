
namespace WheelOfFortuneConsole.Model {
    public class WofPhrases {
        private static List<string> phrases = new List<string> {
            "Remains of the day", "No time to kill", "Thank god its Friday", "May the force be with you",
            "Whats up Doc", "Bond James Bond", "What time is it", "A bigger bang for your buck", "A Blessing In Disguise",
            "A Chip On Your Shoulder", "A Dime A Dozen", "A Piece Of Cake","Actions Speak Louder Than Words",
            "Barking Up The Wrong Tree", "Beating Around The Bush", "Better Late Than Never", "Bite The Bullet",
            "Break The Ice", "Burning The Midnight Oil","Caught Red-Handed", "Cost An Arm And A Leg", "Curiosity Killed The Cat",
            "Don't Count Your Chickens Before They Hatch","Every Cloud Has A Silver Lining", "Fit As A Fiddle",
            "Hit The Nail On The Head","It's Raining Cats And Dogs","Let The Cat Out Of The Bag", "On Cloud Nine",
            "Once In A Blue Moon","Piece Of The Pie", "Sit Tight", "The Ball Is In Your Court"
        };

        public static string GetPhrase() {
            Random rand = new Random();
            int idx = rand.Next(phrases.Count());
            string phrase = phrases[idx];
            // removing from list so we won't play the same phrase twice
            phrases.RemoveAt(idx);
            return phrase.ToUpper();
        }
    }
}
