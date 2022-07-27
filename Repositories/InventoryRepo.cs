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

        public string DeleteInventory(int id)
        {
            string stcode = string.Empty;
            try
            {
                var inventory = _context.Inventoriess.Find(id);
                if (inventory != null)
                {
                    _context.Inventoriess.Remove(inventory);
                    _context.SaveChanges();
                    stcode = "200";
                }
                else
                {
                    stcode = "400";
                }
            }
            catch
            {
                stcode = "400";
            }
            return stcode;
        }

        public List<Inventory> GetAllInventories()
        {
            List<Inventory> inventory = _context.Inventoriess.ToList();
            return inventory;
        }

        public string GetInventoryById(int Id)
        {
            string stcode = string.Empty;
            try
            {
                Inventory? inv = _context.Inventoriess.Find(Id);
                if (inv != null)
                {

                    _context.SaveChanges();
                    stcode = "200";
                }
                else
                {
                    stcode = "400";
                }
            }
            catch (Exception e)
            {

                stcode = e.Message;
            }
            return stcode;
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
