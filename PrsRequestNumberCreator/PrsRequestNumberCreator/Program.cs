using System.Text;

namespace PrsRequestNumberCreator {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Request Number Creator!");
            Console.WriteLine("These #s will be based on the current date.\n");

            Console.WriteLine("The format for a request # is 'R{YYMMDD###}', where '###' is the 9 digit #:");
            Console.WriteLine("Here are 10 request #s for today: ");
            int requestCounter = 0;
            for (int i = 0; i < 10; i++) {
                StringBuilder requestNbr = new StringBuilder("R");
                string dateStr = String.Format("{0:yyMMdd}", DateTime.Now);
                //string yy = today.Year.ToString().Substring(2);
                //string mm = today.Month.ToString().PadLeft(2, '0');
                //string dd = today.Day.ToString().PadLeft(2, '0');
                requestCounter++;
                string count = requestCounter.ToString().PadLeft(3, '0');
                requestNbr.Append(dateStr).Append(count);
                Console.WriteLine($"Request[{i}]: {requestNbr}");
            }
            


            Console.WriteLine("Bye");
        }
    }
}
