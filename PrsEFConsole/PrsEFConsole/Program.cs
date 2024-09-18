using PrsEFConsole.Db;
using PrsEFConsole.Models;

namespace PrsEFConsole {
    internal class Program {
        private static UserDb userDb = new UserDb();
        private static VendorDb vendorDb = new VendorDb();
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the PRS EF Console App!");

            // get users
            List<User> users = userDb.GetUsers();
            Console.WriteLine("List of users:");
            foreach (User user in users) {
                Console.WriteLine($"id: {user.Id}, uname: {user.Username}, fullname: {user.LastName}, {user.FirstName}");
            }


            // get vendors
            List<Vendor> vendors = vendorDb.GetVendors();
            Console.WriteLine("List of vendors:");
            foreach (Vendor v in vendors) {
                Console.WriteLine($"id: {v.Id}, name: {v.Name}, code: {v.Code}");
            }

            Console.WriteLine("Bye");
        }
    }
}
