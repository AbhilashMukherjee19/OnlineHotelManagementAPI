using Microsoft.EntityFrameworkCore;
using OnlineHotelManagementAPI.Models;

namespace OnlineHotelManagementAPI.Repositories
{
    public class GuestRepo : IGuest
    {
        readonly HotelContext _dbContext;
        public GuestRepo(HotelContext context)
        {
            _dbContext = context;
        }
        #region GetAllGuests
        public List<Guest> GetAll()
        {
            try
            {
                return _dbContext.Guests.ToList();
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region GetGuestById
        public Guest GetById(int id)
        {
            try
            {
                Guest? guest = _dbContext.Guests.Find(id);
                if (guest != null)
                {
                    return guest;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region AddGuest
        public string AddGuest(Guest guest)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.Guests.Add(guest);
                _dbContext.SaveChanges();
                stcode = "200";
            }
            catch
            {
                stcode = "400";
            }
            return stcode;
        }
        #endregion

        #region UpdateGuest
        public string UpdateGuest(Guest guest)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.Entry(guest).State = EntityState.Modified;
                _dbContext.SaveChanges();
                stcode = "200";
            }
            catch
            {
                stcode = "400";
            }
            return stcode;

        }
        #endregion

        #region DeleteGuest
        public string RemoveGuest(int id)
        {
            string stcode = string.Empty;
            try
            {
                var guest = _dbContext.Guests.Find(id);
                if (guest != null)
                {
                    _dbContext.Guests.Remove(guest);
                    _dbContext.SaveChanges();
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
    }
}
