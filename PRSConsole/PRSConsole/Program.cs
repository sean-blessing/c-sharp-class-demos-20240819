namespace PRSConsole {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Purchase Request System Console App!");

            PrintSectionHeader("Create some Users");



            PrintSectionHeader("Create some Vendors");


            Console.WriteLine("Bye");
        }

        private static void PrintSectionHeader(string sectionHeader) {
            Console.WriteLine(GetSeparator('=', sectionHeader.Length));
            Console.WriteLine(sectionHeader);
            Console.WriteLine(GetSeparator('=', sectionHeader.Length));
        }

        private static string GetSeparator(char separator, int length) {
            string separatorString = "=";
            separatorString = separatorString.PadRight(length, '=');
            return separatorString;
        }
    }
}
