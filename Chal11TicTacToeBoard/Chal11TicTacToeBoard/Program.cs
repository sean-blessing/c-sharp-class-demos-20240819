using System;

namespace Chal11TicTacToeBoard {
    internal class Program {

        private static string[,] grid = {
            {"1", "2", "3"}, // Row 1
            {"4", "5", "6"}, // Row 2
            {"7", "8", "9"}  // Row 3
        };
        static void Main(string[] args) {
            Console.WriteLine("Welcome to Tic Tac Toe Board!!");
            foreach (var row in grid) {
                Console.WriteLine(row);
            }
            //DisplayGrid();

            Console.WriteLine("Bye");
        }

        private static void DisplayGrid() {
            Console.WriteLine();
            Console.WriteLine("+---+---+---+");
            foreach (var row in grid) {
                Console.Write("|");
                foreach (char column in row) {
                    Console.Write(" " + column + " |");
                }
                Console.WriteLine();
                Console.WriteLine("+---+---+---+");
            }
            Console.WriteLine();
        }
    }
}
