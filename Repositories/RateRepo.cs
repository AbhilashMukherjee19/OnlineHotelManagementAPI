using OnlineHotelManagementAPI.Models;

namespace OnlineHotelManagementAPI.Repositories
{
    public class RateRepo : IRate
    {
        private HotelContext _context;

        public RateRepo(HotelContext context)
        {
            _context = context;
        }

        #region GetAllRate
        public List<Rate> GetAllRate()
        {
            try
            {
                List<Rate> rate = _context.Rates.ToList();
                return rate;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region InsertRate
        public string InsertRate(Rate rate)
        {
            string stcode = string.Empty;
            try
            {
                _context.Rates.Add(rate);
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

        #region UpdateRate
        public string UpdateRate(Rate rate)
        {
            string stcode = string.Empty;
            try
            {
                _context.Rates.Update(rate);
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
