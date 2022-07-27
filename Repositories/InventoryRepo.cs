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

        #region DeleteInventory 
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
        #endregion

        #region GetAllInventories
        public List<Inventory> GetAllInventories()
        {
            try
            {
                List<Inventory> inventory = _context.Inventoriess.ToList();
                return inventory;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region GetInventoryById
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
        #endregion

        #region InsertInventory
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
        #endregion

        #region SaveInventory 
        public void SaveInventory(Inventory inventory)
        {
            _context.SaveChanges();
        }
        #endregion

        #region UpdateInventory
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
        #endregion
    }
}
