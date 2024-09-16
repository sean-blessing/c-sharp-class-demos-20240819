using HangmanConsole.Model;

namespace HangmanConsole {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Hangman Game!\n");
            Console.WriteLine("Rules of the game - filled in later.\n");
            HangmanWords words = new HangmanWords();
            string choice = "y";
            while (choice == "y") {
                // game initialization
                string word = words.GetRandomWord();
                string hiddenWord = words.GetHiddenWord(word);
                int incorrectGuesses = 0;
                Boolean wordGuessed = false;
                List<string> lettersGuessed = new List<string>();
                while (incorrectGuesses != 6 && !wordGuessed) {
                    Console.WriteLine(GetHangmanImage(incorrectGuesses));
                    Console.WriteLine($"hint: {word}");
                    Console.WriteLine($"hidden word: {words.DisplayHiddenWord(hiddenWord)}");
                    Console.WriteLine($"letters guessed: {GetLettersGuessedString(lettersGuessed)}");
                    Console.WriteLine("===========================================");
                    string letterGuess = PromptInput("Enter a Letter: ");
                    // if letterGuess is NOT in lettersGuessed:
                    // -- is letterGuess in word?
                    //    -- update hiddenWord w/ letterGuess
                    //    -- Check hiddenWord - if no underscores remain:
                    //       -- wordGuessed = true
                    // -- else
                    //    -- increment incorrectGuesses by 1
                    // else 
                    // -- Display a message (letter already guessed, try again)
                }
                // Display win or loss message
                // - Display the hangman image?
                // - Display the word?

                choice = PromptInput("Play again? ");
            }
            Console.WriteLine("Bye");
        }

        private static string PromptInput(string prompt) {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        private static string GetLettersGuessedString(List<string> lettersGuessed) {
            string str = "";
            if (lettersGuessed.Count != 0) {
                foreach (string s in lettersGuessed) {
                    str += (s + " ");
                }
            }
            return str;
        }

        private static string GetHangmanImage(int incorrectGuesses) {
            string[] images = {
                """
                ------
                |    |
                |    
                |  
                |   
                |
                --------
                """,
                """
                ------
                |    |
                |    O
                |  
                |   
                |
                --------
                """,
                """
                ------
                |    |
                |    O
                |    |
                |   
                |
                --------
                """,
                """
                ------
                |    |
                |    O
                |   /|
                |   
                |
                --------
                """,
                """
                ------
                |    |
                |    O
                |   /|\
                |   
                |
                --------
                """,
                """
                ------
                |    |
                |    O  
                |   /|\
                |   / 
                |
                --------
                """,
                """
                ------
                |    |
                |    O
                |   /|\
                |   / \
                |
                --------
                """
            };
            return images[incorrectGuesses];
        }
    }
}
