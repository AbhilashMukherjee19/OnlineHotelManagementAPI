using Microsoft.EntityFrameworkCore;
using OnlineHotelManagementAPI.Models;

namespace OnlineHotelManagementAPI.Repositories
{
    public class RoomRepo : IRoom
    {
        readonly HotelContext _dbContext;
        public RoomRepo(HotelContext context)
        {
            _dbContext = context;
        }
        #region GetAllRooms
        public List<Room> GetAll()
        {
            try
            {
                return _dbContext.Rooms.ToList();
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region GetRoomById
        public Room GetById(int id)
        {
            try
            {
                Room? room = _dbContext.Rooms.Find(id);
                if (room != null)
                {
                    return room;
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

        #region AddRoom
        public string AddRoom(Room room)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.Rooms.Add(room);
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

        #region UpdateRoom
        public string UpdateRoom(Room room)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.Entry(room).State = EntityState.Modified;
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

        #region DeleteRoom
        public string RemoveRoom(int id)
        {
            string stcode = string.Empty;
            try
            {

                var room = _dbContext.Rooms.Find(id);
                if (room != null)
                {
                    _dbContext.Rooms.Remove(room);
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
