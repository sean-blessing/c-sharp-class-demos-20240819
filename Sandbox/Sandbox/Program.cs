using System;
using System.Collections.Generic;

namespace Sandbox {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to my sandbox. Let's play!");

            // Holly question 8/27 int vs Int32
            int a = 5;
            Int32 b = 20;

            // SB Data Validation Testing - 8/28
            // test for int

            string[] values = { null, "160519", "five", "9432.0", "16,667",
                          "   -322   ", "+4302", "(100);", "01FA" };
            foreach (var value in values) {
                Console.Write($"value: [{value}]\t");
                int number;

                bool success = int.TryParse(value, out number);
                if (success) {
                    Console.WriteLine($"Converted '{value}' to {number}.");
                }
                else {
                    Console.WriteLine($"Attempted conversion of '{value ?? "<null>"}' failed.");
                }
                Console.WriteLine("=================================");
            }

            Console.WriteLine("Try it in a method we can use...");
            int number1 = PromptInt("Enter a whole number: ");

            // Lists
            List<String> names = new List<String>();
            names.Add("Sarika");
            names.Add("Chris");
            names.Add("Brendan");
            names.Add("Graydon");
            names.Add("Graham");
            names.Add("Brandon");
            names.Add("Sean");
            names.Add("Holly");

            foreach (var name in names) {
                Console.WriteLine(name);
            }

            List<int> numbers = new List<int>();

            Console.WriteLine("bye");
        }

        static private int PromptInt(string prompt) {
            int wholeNumber = 0;
            // using while true w/ break
            while (true) {
                Console.Write(prompt);
                if (!int.TryParse(Console.ReadLine(), out wholeNumber)) {
                    Console.WriteLine("Not a whole number. Try again.");
                }
                else {
                    break;
                }
            }
            return wholeNumber;
        }
    }
}
