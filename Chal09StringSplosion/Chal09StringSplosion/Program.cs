namespace Chal09StringSplosion {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to Challenge 9, StringSplosion!");
            // substring demo
            //string fullName = "Bob Marley";
            //Console.WriteLine($"fullname substring (0,fullName.length): {fullName.Substring(0,fullName.Length)}");
            //Console.WriteLine($"firstname substring(0,2): {fullName.Substring(0,3)}");
            //Console.WriteLine($"lastname substring(4): {fullName.Substring(4)}");

            //Given a non-empty string like "Code" return a string like "CCoCodCode".

            Console.WriteLine($"Code: {StringSplosion("Code")}");
            Console.WriteLine($"abc: {StringSplosion("abc")}");
            Console.WriteLine($"ab: {StringSplosion("ab")}");
            Console.WriteLine("Bye");
        }

        public static String StringSplosion(String str) {
            string newString = "";
            // Test Case "Code" -> "CCoCodCode"
            // "abc" -> "aababc"
            // "ab" -> "aab"

            // index for loop (int i=0;i< str.length; i++) through str
            // - get substring (0,i)
            // newString += str.substring(0,i)
            for (int i = 0; i<= str.Length; i++) {
                newString += str.Substring(0, i);
            }

            return newString;
        }
    }
}
