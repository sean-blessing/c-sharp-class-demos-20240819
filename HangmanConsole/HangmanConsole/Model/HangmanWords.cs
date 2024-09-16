
namespace HangmanConsole.Model {
    public class HangmanWords {
        List<string> words = new();

        public HangmanWords() {
            words = new List<string> { "strange", "halloween", "crystal", "program", "super", "noisey",
                                       "table", "history", "crazy", "dodgey", "standard", "automobile"};
        }

        public string GetRandomWord() {
            Random rand = new Random();
            return words[rand.Next(words.Count)];
        }

        public string GetHiddenWord(string word) {
            string hiddenWord = "";
            foreach (char c in word) {
                hiddenWord += "_";
            }
            return hiddenWord;
        }

        public string DisplayHiddenWord(string hiddenWord) {
            string displayString = "";
            foreach (char c in hiddenWord) {
                displayString += c + " ";
            }
            return displayString;
        }
    }
}
