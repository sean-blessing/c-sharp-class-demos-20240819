namespace Proj15_02_Wizard_Inventory {
    internal class Program {
        // inventory is now a class property, accessible by all methods throughout Program
        static List<string> inventory = new List<string>();

        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Wizard Inventory Game\n");

            // add initial items to inventory
            inventory.Add("wooden staff");
            inventory.Add("wizard hat");
            inventory.Add("cloth shoes");

            DisplayMenu();
            string command = "";
            while (command != "exit") {
                command = GetString("\nCommand: ");
                Console.WriteLine();
                switch (command) {
                    case "menu":
                        DisplayMenu();
                        break;
                    case "show":
                        ShowInventory();
                        break;
                    case "grab":
                        GrabItem();
                        break;
                    case "edit":
                        EditItem();
                        break;
                    case "drop":
                        DropItem();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Invalid command. Try again.");
                        break;
                }
            }
            Console.WriteLine("\nBye. Thanks for playing!");
        }

        private static void DropItem() {
            int itemNum;
            Console.WriteLine("Drop an Item:");
            Console.WriteLine("=============");
            // drop: prompt user for item #,
            itemNum = GetInt("Delete Item #: ", 1, inventory.Count());
            // remove item by #,
            string delItem = inventory[itemNum - 1];
            inventory.Remove(delItem);
            Console.WriteLine($"{delItem} was dropped.");
        }

        private static void EditItem() {
            Console.WriteLine("Edit an Item:");
            Console.WriteLine("=============");
            // edit: prompt user for item #,
            int itemNum = GetInt("Edit Item #: ", 1, inventory.Count());
            // prompt user for updated item name,
            string updatedName = GetString("Updated Item Name: ");
            // save updated name
            inventory[itemNum - 1] = updatedName;
            Console.WriteLine($"Item #{itemNum} was updated.");
        }

        private static void GrabItem() {
            Console.WriteLine("Grab an Item:");
            Console.WriteLine("=============");
            if (inventory.Count() >= 4) {
                Console.WriteLine("You can't carry any more items. Please drop an item first.");
            }
            else {
                string newItem = GetString("New Item Name: ");
                inventory.Add(newItem);
                Console.WriteLine($"{newItem} was added.");
            }
        }

        private static void ShowInventory() {
            Console.WriteLine("Show All Items:");
            Console.WriteLine("===============");
            for (int i = 0; i < inventory.Count(); i++) {
                Console.WriteLine($"{i + 1}. {inventory[i]}");
            }
        }

        private static void DisplayMenu() {
            Console.WriteLine("COMMAND MENU");
            Console.WriteLine("menu - Redisplay menu");
            Console.WriteLine("show - Show all items");
            Console.WriteLine("grab - Grab an item");
            Console.WriteLine("edit - Edit an item");
            Console.WriteLine("drop - Drop an item");
            Console.WriteLine("exit - Exit program");
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

        private static string GetString(string prompt) {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }
    }
}
