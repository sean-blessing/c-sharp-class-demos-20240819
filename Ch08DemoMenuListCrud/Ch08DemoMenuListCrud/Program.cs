namespace Ch08DemoMenuListCrud {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Demo of Menus, Lists, and CRUD!");

            // Create an empty list of names
            List<string> names = new List<string>();
            int option = 0;

            while (option != 4) {
                // Display a menu of options
                // 1 - List names
                // 2 - Add name
                // 3 - Remove name
                // 4 - Exit the app
                // Prompt user for option
                option = GetInt(GetMenu(), 1, 4);

                // Perform that selected option
                switch (option) {
                    case 1:
                        // list names
                        Console.WriteLine("\nNames:");
                        for (int i=0; i < names.Count(); i++) {
                            Console.WriteLine($"{i + 1}: {names[i]}");
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        // add name
                        Console.WriteLine("\nAdd a Name:");
                        string name = getString("Name to Add: ");
                        names.Add(name);
                        Console.WriteLine();
                        break;
                    case 3:
                        // remove name
                        Console.WriteLine("\nRemove a Name:");
                        int nameNbr = GetInt("Name # to remove: ", 1, names.Count());
                        names.RemoveAt(nameNbr - 1);
                        Console.WriteLine("Name removed.\n");
                        break;
                    case 4:
                        // exit
                        break;
                }
            }

            Console.WriteLine("bye");
        }

        private static string getString(string prompt) {
            Console.Write(prompt);
            string strValue = Console.ReadLine();
            return strValue;
        }

        private static int GetInt(string prompt, int min, int max) {
            int number = 0;
            Boolean isValid = false;

            while (!isValid) {
                try {
                    Console.Write(prompt);
                    number = Int32.Parse(Console.ReadLine());
                    if (number < min) {
                        Console.WriteLine($"Invalid entry: number less than min ({min})");
                        continue;
                    }
                    else if (number > max) {
                        Console.WriteLine($"Invalid entry: number greater than max ({max})");
                        continue;
                    }
                    else {
                        break;
                    }
                }
                catch (Exception e) {
                    Console.WriteLine("Invalid entry: please enter a valid integer.");
                    continue;
                }
            }

            return number;
        }

        static string GetMenu() {
            string menu = "MENU OPTIONS:\n" +
                          "1 - List names\n" +
                          "2 - Add name\n" +
                          "3 - Remove name\n" +
                          "4 - Exit app\n" +
                          "Choose your option: ";
            return menu;
         }
    }
}
