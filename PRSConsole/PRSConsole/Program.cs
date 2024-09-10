using PRSConsole.Models;

namespace PRSConsole {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Purchase Request System Console App!");

            PrintSectionHeader("Create some Users");
            User u1 = new User(1, "sblessing", "testpwd", "Sean", "Blessing", "444-333-5555", "sean@test.com",
                true,false);
            User u2 = new User(2, "dgrohl", "rockit", "Dave", "Grohl", "111-222-3333", "dave@ff.com", true, true);
            Console.WriteLine("Users:");
            Console.WriteLine(u1);
            Console.WriteLine(u2);

            PrintSectionHeader("Create some Requests");
            Request req1 = new Request(1, u1, "R0001", "Need new supplies for my desk.", "Need this for my job",
                                        new DateOnly(2024, 9, 17), "Pick-up", "NEW", 0.0m, DateTime.Now, null);
            Console.WriteLine(req1);


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
