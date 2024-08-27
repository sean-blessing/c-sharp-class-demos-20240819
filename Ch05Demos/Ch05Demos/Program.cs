namespace Ch05Demos {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Chapter 5 demos!");
            // p. 139 Relational Operators (==, !=, >, etc.)
            //string choice = "y";

            //while (choice == "y") {
            //    Console.WriteLine("In while loop... ");
            //    choice = "anything else";
            //}

            //int a = 10;
            //Console.WriteLine($"a != 10? {a != 10}");
            //Console.WriteLine($"a < 20? {a < 20}"); 
            //Console.WriteLine($"a >= 10? {a >= 10}");

            // p. 141 Logical Operators
            //string lightColor = "Yellow";
            //Boolean pedestrianInCrosswalk = true;

            //if ( lightColor == "Green" && !pedestrianInCrosswalk ) {
            //    Console.WriteLine("Go!");
            //}
            //else
            //{
            //    Console.WriteLine("Stop!");
            //}

            // Two things make Sean happy: ice cream, payday
            //Boolean iceCream = false;
            //Boolean payDay = true;

            //if (iceCream && payDay) {
            //    Console.WriteLine("double win!");
            //}
            //else if (iceCream || payDay) {
            //    Console.WriteLine("1 out of 2, not bad!");
            //}

            // p. 143 If-Else Statements
            // traffic light:
            // - color: red - stop, yellow - slow, green - go
            // - distanceToLight: > 30 slow, < 30 speed up
            //lightColor = "green";
            //int distanceToLight = 28;

            //if (lightColor == "red") {
            //    Console.WriteLine("Light is Red - Stop");
            //}
            //else if (lightColor == "yellow") {
            //    Console.WriteLine("Light is Yellow...");
            //    if (distanceToLight > 30) {
            //        Console.WriteLine("More than 30 yards away - Stop");
            //    }
            //    else {
            //        Console.WriteLine("Less than 30 yards away - Spped Up!");
            //    }
            //}
            //else {
            //    // lightColor green
            //    Console.WriteLine("Light is Green - Go");
            //}


            // p. 145 Switch Statements
            //Console.WriteLine("Scary Adventure Game Options!");
            //Console.WriteLine("You are at the end of a long corridor.");
            //Console.WriteLine("There are three doors. Which one will you choose?!");
            //Console.WriteLine("1 - To the right is a red door with a skull and croosbones!");
            //Console.WriteLine("2 - To the left is a blue door with a snake and rock!");
            //Console.WriteLine("3 - Straight ahead is a purple door with daisies on it!");
            //Console.Write("Which Door (1/2/3)? ");
            //int door = Int32.Parse(Console.ReadLine());
            //switch (door) {
            //    case 1:
            //        Console.WriteLine("Red door - immenent death... you are consumed in flames!");
            //        break;
            //    case 2:
            //        Console.WriteLine("Blue door - got lucky... snakes are asleep and you walk right passed!");
            //        break;
            //    case 3:
            //        Console.WriteLine("Purple door - too bad... deadly daisies cause you to sneeze to death!");
            //        break;
            //}

            // p. 151 Conditional / ternary Operator
            string shippingStatus = "2-day";
            double charge = 0;

            // if status is 2 day, charge is $5, otherwise charge is $2
            // charge determined by shippingStatus
            //if (shippingStatus == "2-day")
            //    charge = 5;
            //else
            //    charge = 2;
            charge = shippingStatus == "2-day" ? 5 : 2;
            Console.WriteLine($"charge = {charge}");


            // p. 155 While vs Do-While Loops
            // Already done while loops so no demo,
            // but don't use do-while!!!

            // p. 157 For Loops
            // loops that run a certain # of times
            // count to 10!
            for ( int i = 0; i <= 10; i++ ) {
                Console.WriteLine($"i is {i}");
            }

            Console.WriteLine("2 to 20 by 2's...");
            for (int i = 2;i <= 20;i += 2 ) {
                Console.WriteLine($"i is {i}");
            }

            // p. 159 Continue/Break in While / Foor Loops
            //while (true) {
            //    // do stuff
            //    Console.WriteLine("In an infinite loop!");
            //    Console.Write("Are you bored yet (y/n)? ");
            //    string answer = Console.ReadLine().ToLower();
            //    if (answer == "y") {
            //        break;
            //    }
            //}

            // while loop w/ break and continue
            // prompt for even number
            // multiple even number by 10
            // break when odd number entered
            // Only accept max of 10 entered
            // break goes to end, continue back to beginning
            while (true) {
                int number = 0;

                Console.WriteLine("Enter even number");
                number = Int32.Parse(Console.ReadLine());
                if ( number > 10 ) {
                    Console.WriteLine("Nbr greater than 10, try again.");
                    continue;
                }
                else if (number % 2 == 0 ) {
                    Console.WriteLine("Even number entered!");
                }
                else {
                    Console.WriteLine("Odd number entered... boooo!");
                    break;
                }
                int result = number * 10;
                Console.WriteLine($"result is {result}");
            }



            // p. 161 Integrated Debugger

            Console.WriteLine("bye");
        }
    }
}
