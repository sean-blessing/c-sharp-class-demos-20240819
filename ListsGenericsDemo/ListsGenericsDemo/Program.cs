namespace ListsGenericsDemo {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Do you remember Lists... and that they utilize Generics???!");

            List<string> names = new(){ "Chris", "Sarika", "Holly", "Graham"};
            names.Add("Brandon");

            List<int> numbers = new() { 1, 2, 3, 4, 5 };
            //numbers.Add("six");

            Dictionary<int, string> months = new ();
            months.Add(1, "Jan");
            months.Add(2, "Feb");
            months.Add(3, "Mar");
            months.Add(4, "Apr");
            months.Add(5, "May");
            months.Add(6, "Jun");
            months.Add(7, "Jul");
            months.Add(8, "Aug");
            months.Add(9, "Sep");
            months.Add(10, "Oct");
            months.Add(11, "Nov");
            months.Add(12, "Dec");

            Console.WriteLine($"Month 5 = {months[5]}");
            //months.Add("two", 2);



            Console.WriteLine("bye");
        }
    }
}
