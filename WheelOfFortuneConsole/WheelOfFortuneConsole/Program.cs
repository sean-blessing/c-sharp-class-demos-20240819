namespace WheelOfFortuneConsole {
    internal class Program {
        // initialize global variables
        // Note: tech decision made: storing values as strings, but these could be ints
        static List<string> wheelValues = new List<string> {
            "bankrupt", "lose a turn", "100", "150", "200", "250", "300", "350",
            "400", "450", "500", "550", "600", "650", "700", "750", "800", "850", "900"
        };
        // do we need an overallBank? Could just add roundBanks.
        decimal overallBank = 0.0m;
        decimal[] roundBanks = { 0.0m, 0.0m, 0.0m};

        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Wheel of Fortune Game!\n");
            Console.WriteLine("Instructions go here. Do this later\n");
            //initialize local variables
            // do variables go here, or at the class level?

            string choice = "Y";
            while (choice == "Y") {
                // what's a 'game'? ==> It's one round of wof
                // - initialize single game local variables

                for (int i = 0; i < 3; i++) {
                    // ** Beginning of a Round!
                    // Display "welcome to round {i}" message
                    // initialize the bank (set a variable to track the roundBank)
                    // get the 'roundPhrase'
                    // generate 'hiddenPhrase'
                    // display 'hiddenPhrase' (inside while or outside?)
                    // while loop for gameplay (loop until user guesses the phrase)
                        // prompt (spin, buyVowel, or guessPhrase)
                        // - if spin
                        //   - spin wheel
                        //      - bankrupt - zero roundBalance, continue
                        //      - lose a turn - continue
                        //      - $$ amount, guess letter
                        //          - check 'roundPhrase' for letter
                        //              - if exists, resolve letter in 'hiddenPhrase'
                        //                  - add $$ to roundBank
                        //              - if not exist, continue
                        //   - buyVowel
                        //      - if enough $$ prompt for vowel
                        //          deduct from roundBank
                        //          if vowel exists, resolve in word
                        //          if vowel not exists, continue
                        //   - guessPhrase
                        //      - prompt for guess
                        //      - if correct win
                        //      - else continue
                        //   - round ends when 'roundPhrase' is guessed, ends this iteration of for loop
                }
                choice = PromptString("Play again? ", ["Y", "N"]);
            }

            Console.WriteLine("Bye");
        }

        // Validation Methods?
        private static string PromptString(string prompt, string[] validStrings) {
            string goodString = "";
            Boolean isValid = false;
            while (!isValid) {
                Console.Write(prompt);
                goodString = Console.ReadLine().ToUpper();
                foreach (string s in validStrings) {
                    if (s == goodString) {
                        isValid = true;
                        break;
                    }
                }
            }

            return goodString;
        }
    }
}
