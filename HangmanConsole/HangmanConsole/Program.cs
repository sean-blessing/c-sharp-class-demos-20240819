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
                    if (lettersGuessed.IndexOf(letterGuess) < 0) {
                        lettersGuessed.Add(letterGuess);
                        if (word.IndexOf(letterGuess) >= 0) {
                            hiddenWord = UpdateHiddenWord(word, hiddenWord, Char.Parse(letterGuess));
                            if (hiddenWord.IndexOf('_') < 0) {
                                wordGuessed = true;
                            }
                        }
                        else {
                            incorrectGuesses++;
                        }
                    }
                    else {
                        Console.WriteLine("Letter already guessed, try again.");
                    }
                }
                if (wordGuessed) {
                    Console.WriteLine("You won!");
                    Console.WriteLine($"The word was '{words.DisplayHiddenWord(hiddenWord)}'");
                }
                else {
                    Console.WriteLine(GetHangmanImage(incorrectGuesses));
                    Console.WriteLine("You lost. Sorry, try again.");
                    Console.WriteLine($"The word was '{word}'.");
                }
                choice = PromptInput("Play again? ");
            }
            Console.WriteLine("Bye");
        }

        private static string UpdateHiddenWord(string word, string hiddenWord, char letterGuess) {
            // accepting hiddenWord (underscoredVersion of word)
            // we know the letterGuess exists in word
            // loop through word, find the index positions where the letterGuess occurs
            //   - then change hiddenWord, at those index positions, to replace that indexposition with letterGuess
            char[] wordCharArray = word.ToCharArray();
            char[] hiddenWordCharArray = hiddenWord.ToCharArray();
            for (int i = 0; i < wordCharArray.Length; i++) {
                if (wordCharArray[i] == letterGuess) {
                    hiddenWordCharArray[i] = letterGuess;
                }
            }
            return new string(hiddenWordCharArray);
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
