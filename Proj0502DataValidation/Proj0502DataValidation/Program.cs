using System.ComponentModel.DataAnnotations;

namespace Proj0502DataValidation {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Data Validator App!");
            const double MIN_DOUBLE = 1;
            const double MAX_DOUBLE = Double.MaxValue;

            // + while loop start - choice
            string choice = "y";
            while (choice == "y") {
                // get input
                // validation:
                // - entries must be doubles
                // - entries must be greater than 0
                double length = getDouble("Enter length: ", MIN_DOUBLE, MAX_DOUBLE);
                double width = getDouble("Enter width: ", MIN_DOUBLE, MAX_DOUBLE);

                // biz logic
                double area = length * width;
                double perimeter = 2 * length + 2 * width;

                // display output
                // display area and perimeter
                Console.WriteLine($"Area:      {area}");
                Console.WriteLine($"Perimeter: {perimeter}");

                // + while loop ends
                // validation - choice: y or n, can't be empty
                choice = getString("Continue (y/n)? ", "y", "n");
            }


            Console.WriteLine("bye");
        }

        // get a required string (empty value not accepted) that is either s1 or s2
        private static string getString(string prompt, string s1, string s2) {
            string strValue = "";

            Boolean isValid = false;

            while (!isValid) {
                Console.Write(prompt);
                strValue = Console.ReadLine().ToLower();
                if (strValue == "") {
                    Console.WriteLine("Error: entry is required.");
                    continue;
                }
                else if (strValue != s1 && strValue != s2) {
                    Console.WriteLine($"Error: entry must be either '{s1}' or '{s2}'.");
                    continue;             
                }
                else {
                    break;
                }
            }

            return strValue;
        }

        private static double getDouble(string prompt, double min, double max) {
            double number = 0.0;
            Boolean isValid = false;

            while(!isValid) {
                try { 
                    Console.Write(prompt);
                    number = Double.Parse(Console.ReadLine());
                    if (number < min) {
                        Console.WriteLine($"Invalid entry: number less than min ({min})");
                        continue;
                    }
                    else if (number > max) {
                        Console.WriteLine($"Invalid entry: number greater than max ({max})");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception e) {
                    Console.WriteLine("Invalid entry: please enter a valid double.");
                    continue;
                }
            }

            return number;
        }
    }
}
