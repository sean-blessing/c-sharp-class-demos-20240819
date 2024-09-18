using PrsEFConsole.Models;

namespace PrsEFConsole.Db {
    public class VendorDb {
        private PrsContext dbContext = new();

        // CRUD Methods
        public List<Vendor> GetVendors() {
            return dbContext.Vendors.ToList();
        }
        public Vendor FindVendor(int id) {
            return dbContext.Vendors.Where(v => v.Id == id).FirstOrDefault();
        }

        public void AddVendor(Vendor vendor) {
            dbContext.Vendors.Add(vendor);
            dbContext.SaveChanges();
        }

        public void UpdateVendor(Vendor vendor) {
            dbContext.SaveChanges();
        }

        public void RemoveVendor(Vendor vendor) {
            dbContext.Vendors.Remove(vendor);
            dbContext.SaveChanges();
        }

    }
}
