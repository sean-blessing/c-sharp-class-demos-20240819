using Ch20EntityFrameworkCorePrep.Models;

namespace Ch20EntityFrameworkCorePrep.Db {
    public class CreditDb {
        private bmdbContext context = new();

        public List<Credit> GetCredits() { 
            return context.Credits.ToList();
        }
    }
}
