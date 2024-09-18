using PrsEFConsole.Models;

namespace PrsEFConsole.Db {
    public class UserDb {
        private PrsContext dbContext = new();

        // CRUD Methods
        public List<User> GetUsers() {
            return dbContext.Users.ToList();
        }
        public User FindUser(int id) {
            return dbContext.Users.Where(u => u.Id == id).FirstOrDefault();
        }

        public void AddUser(User user) {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }

        public void UpdateUser(User user) {
            dbContext.SaveChanges();
        }

        public void RemoveUser(User user) {
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
        }

    }
}
