using Proj11_02_AccountBalance.Model;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

namespace Proj11_02_AccountBalance {
    internal class Program {
        static void Main(string[] args) {
            PrintSectionHeader("Welcome to the Account Balance App!");

            // initialize variables
            CheckingAccount ca = new CheckingAccount(1000m, 1m);
            SavingsAccount sa = new SavingsAccount(1000m, .01);

            // Display Starting Balances
            Console.WriteLine("\nStarting Balances:");
            DisplayBalances(ca, sa);

            Console.WriteLine("\nEnter Transactions for Month\n");

            string choice = "y";

            while (choice == "y") {
                string action = GetString("Withdrawal or Deposit (w/d)? ", "w", "d");
                string account = GetString("Checking or Savings Account (c/s)? ", "c", "s");
                Account selectedAccount = null;
                decimal maxAmount = Decimal.MaxValue;
                decimal minAmount = .01m;
                if (account == "c") {
                    selectedAccount = ca;
                }
                else {
                    selectedAccount = sa;
                }
                if (action == "w" && selectedAccount.Balance <= 0) {
                    Console.WriteLine("$0 account balance, cannot withdraw funds.");
                    continue;
                }
                else if (action == "w") {
                    maxAmount = selectedAccount.Balance;
                }
                // withdrawal * if balance <= 0, don't allow withdrawal
                //              else min is .01, max = balance
                // deposit * min is .01, max = infinity
                decimal amount = GetDecimal("Amount? ", minAmount, maxAmount);
                // adjust the balance
                if (action == "w") {
                    selectedAccount.withdraw(amount);
                }
                else {
                    selectedAccount.deposit(amount);
                }

                choice = GetString("Continue? (y/n) ", "y", "n");
            }

            // Display Monthly Payments and Fees
            sa.ApplyPayment();
            ca.SubtractMonthlyFee();
            Console.WriteLine("\nMonthly Payments and Fees:");
            Console.WriteLine($"Checking Fee:             {ca.MonthlyFee:c}");
            Console.WriteLine($"Savings Interest Payment: {sa.MonthlyInterestPayment:c}");

            // Display Ending Balances
            Console.WriteLine("\nFinal Balances:");
            DisplayBalances(ca, sa);

            Console.WriteLine("Bye");
        }

        private static string GetString(string prompt, string s1, string s2) {
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

        private static decimal GetDecimal(string prompt, decimal min, decimal max) {
            decimal number = 0.0m;
            Boolean isValid = false;

            while (!isValid) {
                Console.Write(prompt);
                Boolean success = Decimal.TryParse(Console.ReadLine(), out number);
                if (!success) {
                    Console.WriteLine("Invalid entry: please enter a valid decimal.");
                }
                else {
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
            }

            return number;
        }

        private static void DisplayBalances(CheckingAccount ca, SavingsAccount sa) {
            Console.WriteLine($"Checking: {ca.Balance:c}");
            Console.WriteLine($"Savings:  {sa.Balance:c}");
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
