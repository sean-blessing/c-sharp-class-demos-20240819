namespace Project0202GradeConverter {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Letter Grade Converter");

            // Start continue loop
            string choice = "y";
            while (choice == "y") {
                // Get User Input - numeric grade
                Console.Write("Enter numeric grade: ");
                int numericGrade = Int32.Parse(Console.ReadLine());

                // Do Business Logic - generate letter grade
                string letterGrade = "F";
                if (numericGrade > 87) {
                    letterGrade = "A";
                }
                else if (numericGrade > 79) {
                    letterGrade = "B";
                }
                else if (numericGrade > 67) {
                    letterGrade = "C";
                }
                else if (numericGrade > 60) {
                    letterGrade = "D";
                }
                // Print Results / Output - print letter grade
                Console.WriteLine("Letter grade: " + letterGrade);
                // End continue loop
                Console.Write("\nContinue (y/n)? ");
                choice = Console.ReadLine();
            }

            Console.WriteLine("bye");
        }
    }
}
