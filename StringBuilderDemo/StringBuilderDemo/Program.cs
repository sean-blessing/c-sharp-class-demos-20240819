using System.Text;

namespace StringBuilderDemo {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("String Builder Demo!");

            string str1 = "abc";
            Console.WriteLine(str1);
            str1 += "def";
            Console.WriteLine(str1);

            Console.WriteLine("StringBuilder");
            StringBuilder strb = new StringBuilder();
            strb.Append(str1);
            Console.WriteLine(strb);
            strb.Remove(2, 2);
            Console.WriteLine(strb);


            Console.WriteLine("Bye");
        }
    }
}
