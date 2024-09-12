using System.Text.RegularExpressions;

namespace Chal6ReplaceVowels {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to Vowel Replacer App!");

            string choice = "y";
            while (choice == "y") {
                Console.Write("Enter sentence: ");
                string sentence = Console.ReadLine();

                string newSentence = ReplaceVowelsWithUnderscoresRegex(sentence);
                Console.WriteLine($"original: {sentence}"); 
                Console.WriteLine($"new: {newSentence}");

                Console.Write("Continue(y/n)? ");
                choice = Console.ReadLine();
            }


            Console.WriteLine("Bye");
        }

        private static String ReplaceVowelsWithUnderscores(String sentence) {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y'};
            // Th_ br_wn f_x j_mp_d _v_r th_ l_g.
            // 1 - loop through letters of the sentence
            foreach (char vowel in vowels) {
                sentence = sentence.Replace(vowel, '_');
            }
            return sentence;
        }
        private static String ReplaceVowelsWithUnderscoresRegex(String sentence) {
            sentence = Regex.Replace(sentence, "[aeiouyAEIOUY]", "_");
            return sentence;
        }
    }

}
