using OnlineHotelManagementAPI.Models;

namespace OnlineHotelManagementAPI.Repositories
{
    public class AdminRepo : IAdmin
    {
        readonly HotelContext _dbContext;
        public AdminRepo(HotelContext context)
        {
            _dbContext = context;
        }
        #region AddAdmin
        public string AddAdmin(Admin admin)
        {
            string stcode = string.Empty;
            try
            {
                _dbContext.Admins.Add(admin);
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
    }
}
