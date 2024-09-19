using SalesDatabaseEFConsole.Models;

namespace SalesDatabaseEFConsole.Db {
    public class CustomerDb : DAO<Customer> {
        private SalesdbContext dbContext = new();

        public void Add(Customer t) {
            dbContext.Customers.Add(t);
            dbContext.SaveChanges();
        }

        public void Delete(Customer t) {
            dbContext.Customers.Remove(t);
            dbContext.SaveChanges();
        }

        public List<Customer> GetAll() {
            return dbContext.Customers.ToList();
        }

        public Customer GetById(int id) {
            return dbContext.Customers.Where(c => c.Id == id).FirstOrDefault(); ;
        }

        public void Update(Customer t) {
            dbContext.SaveChanges();
        }
    }
}
