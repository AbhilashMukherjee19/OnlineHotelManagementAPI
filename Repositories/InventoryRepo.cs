using OnlineHotelManagementAPI.Models;

namespace OnlineHotelManagementAPI.Repositories
{
    public class InventoryRepo : IInventory
    {
        private HotelContext _context;

        public InventoryRepo(HotelContext context)
        {
            _context = context;
        }

        public string DeleteInventory(int inventory)
        {
            string msg = "";
                Inventory deleteInventory = _context.Inventoriess.Find(inventory);
                {
                    _context.Inventoriess.Remove(deleteInventory);
                    _context.SaveChanges();
                    msg = "Deleted";
                }
                return msg;
        }

        public List<Inventory> GetAllInventories()
        {
            List<Inventory> inventory = _context.Inventoriess.ToList();
            return inventory;
        }

        public Inventory GetInventoryById(int Id)
        {
            Inventory inventory;
            string stcode = string.Empty;
            try
            {
                _context.Inventoriess.Where(x => Id == Id).FirstOrDefault();

                inventory = _context.Inventoriess.Find(Id);
                _context.SaveChanges();
                stcode = "200";
            }
            catch (Exception e)
            {
                throw e;
                stcode = "400";
            }
            return inventory;
        }

        public string InsertInventory(Inventory inventory)
        {
            string stcode = string.Empty;
            try
            {
                _context.Inventoriess.Add(inventory);
                _context.SaveChanges();
                stcode = "200";

            }
            catch (Exception e)
            {
                stcode = "400";
            }
            return stcode;
        }

        public void SaveInventory(Inventory inventory)
        {
            _context.SaveChanges();
        }

        public string UpdateInventory(Inventory inventory)
        {
            string stcode = string.Empty;
            try
            {
                _context.Inventoriess.Update(inventory);
                _context.SaveChanges();
                stcode = "200";

            }
            catch (Exception e)
            {
                stcode = "400";
            }
            return stcode;
        }
    }
}
