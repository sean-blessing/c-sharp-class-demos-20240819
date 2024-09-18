namespace NullableTypesConsole {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the nullable types demo!");

            // string defined as an empty string - not null!
            string str = "";
            Console.WriteLine($"str = {str}.");

            string? nullString  = null;
            Console.WriteLine($"nullString = {nullString}.");

            //Console.WriteLine($"nullString.ToUpper() = {nullString.ToUpper()}.");

            int a = 0;
            int? b = null;

            Console.WriteLine($"a, b = {a}, {b}.");
            Console.WriteLine($"a + b = {a + b}.");



            Console.WriteLine("Bye");
        }
    }
}
