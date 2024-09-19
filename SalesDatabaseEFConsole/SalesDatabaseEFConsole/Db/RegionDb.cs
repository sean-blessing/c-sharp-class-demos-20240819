using SalesDatabaseEFConsole.Models;

namespace SalesDatabaseEFConsole.Db {
    internal class RegionDb : DAO<Region> {
        private SalesdbContext dbContext = new();
        public void Add(Region t) {
            dbContext.Regions.Add(t);
            dbContext.SaveChanges();
        }

        public void Delete(Region t) {
            dbContext.Regions.Remove(t);
            dbContext.SaveChanges();
        }

        public List<Region> GetAll() {
            return dbContext.Regions.ToList();
        }

        public Region GetById(int id) {
            return dbContext.Regions.Where(r => r.Id == id).FirstOrDefault(); ;
        }

        public void Update(Region t) {
            dbContext.SaveChanges();
        }
    }
}
