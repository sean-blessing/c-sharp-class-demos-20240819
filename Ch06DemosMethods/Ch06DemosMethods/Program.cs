namespace Ch06DemosMethods {
    internal class Program {

        // no params and no return
        //static private void PrintHello() {
        //    Console.WriteLine("Hello, from PrintHello method.");
        //}

        // one param and no return
        static private void PrintHello(string name = "No Name") {
            Console.WriteLine($"Hello, {name}. Welcome to our application!");
        }

        // one param and return a int
        // prompt the user for a whole number
        // Chapter 7 Exception Handling - p. 207
        static private int PromptInt(string prompt) {
            int wholeNumber = 0;
            // using while true w/ break
            while (true) {
                try {
                    Console.Write(prompt);
                    wholeNumber = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e) {
                    // Console.Error.WriteLine(e.ToString());
                    Console.WriteLine("Error: Please enter a valid integer.");
                }
            }
            return wholeNumber;
        }

        static private int PromptPositiveInt(string prompt) {
            int wholeNumber = 0;
            while (true) {
                wholeNumber = PromptInt(prompt);
                if (wholeNumber < 0) {
                    Console.WriteLine("Error: number must be 0 or greater.");
                }
                else {
                    break;
                }
            }
            return wholeNumber;
        }

        static private int PromptInt(string prompt, int minVal, int maxVal) {
            int wholeNumber = 0;
            Boolean validEntry = false;
            while (!validEntry) {
                wholeNumber = PromptInt(prompt);
                if (wholeNumber < minVal) {
                    Console.WriteLine($"Error: Number is less than min val, {minVal}.");
                }
                else if (wholeNumber > maxVal) {
                    Console.WriteLine($"Error: Number is greater than max val, {maxVal}.");
                }
                else {
                    validEntry = true;
                }
            }

            return wholeNumber;
        }

        static void Main(string[] args) {
            Console.WriteLine("Welcome to Chapter 6 Demos!");

            // p. 171 Coding a method
            // - calling a method to print to the console
            // p. 173 Calling a Method
            //PrintHello();
            //PrintHello("Bob");
            //PrintHello("Susan");
            //PrintHello("Dolly Parton");
            //PrintHello("George Lucas");

            //// prompt for positive integers, within range 1 to 100
            //int number1 = PromptInt("Enter number 1: ", 1, 100);
            //int number2 = PromptInt("Enter number 2: ", 1, 100);
            //Console.WriteLine($"sum = {number1 + number2}");

            //int monthNumber = PromptInt("Enter month number: ", 1, 12);
            //int dayNumber = PromptInt("Enter day of week number: ", 1, 7);
            //int dayOfYear = PromptInt("Enter day of the year: ", 1, 365);
            //int quarters = PromptInt("Enter # of quarters in a game: ", 1, 4);

            //// p. 175 Optional Params
            //PrintHello();

            // p. 177 Replacing Code w/ a Method via Refactor

            // p. 181 ref Keyword
            int a = 1;
            Console.WriteLine($"a = {a}");
            Console.WriteLine("Calling incrementNumber...");
            IncrementNumber(ref a);
            Console.WriteLine($"a = {a}");


            // p. 183 out, in Keywords

            // p. 185 Tuples, p. 187 more on Tuples

            // without tuples, define a movie
            string title = "Awesome Movie";
            int year = 2020;
            string rating = "PG";
            string director = "Steve West";

            // define a movie as a tuple
            var myMovie = (title, year, rating, director);
            Console.WriteLine(myMovie);
            Console.WriteLine($"title = {myMovie.title}");
            Console.WriteLine($"year = {myMovie.year}");

            // named tuple


            // p. 189 - skip the rest

            // generate 100 random #s, between 1 and 100
            for (int i = 0; i < 100; i++) {
                Console.WriteLine($"random int: {GenerateRandomNumber(1, 101)}");
            }

            Console.WriteLine("Bye");
        }

        private static void IncrementNumber(ref int number) {
            Console.WriteLine("inside of incrementNumber");
            number++;
            Console.WriteLine($"after increment, number is: {number}");
        }

        private static int GenerateRandomNumber(int minVal, int maxVal) {
            return new Random().Next(minVal, maxVal);
        }
    }

}
