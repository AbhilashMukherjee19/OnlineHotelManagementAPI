using OnlineHotelManagementAPI.Models;

namespace OnlineHotelManagementAPI.Repositories
{
    public class StaffRepo : IStaff
    {
        private HotelContext _context;

        public StaffRepo(HotelContext context)
        {
            _context = context;
        }

        //public int id { get; private set; }
        //public int Id { get; private set; }
        //public object StaffId { get; private set; }

        public string DeleteStaff(int Id)
        {
            string msg = "";
            Staff deleteStaff = _context.Staffs.Find(Id);
            if(deleteStaff != null)
            { 
                _context.Staffs.Remove(deleteStaff);
                _context.SaveChanges();
                msg = "Deleted";
            }
            else
            {
                msg = "Id not valid";
            }
            return msg;
        }

        public List<Staff> GetAllStaff()
        {
            List<Staff> staff = _context.Staffs.ToList();
            return staff;
        }

        public Staff GetStaffById(int id)
        {
            string stcode = string.Empty;
            try
            {
                Staff staff = _context.Staffs.Find(id);
                _context.SaveChanges();
                stcode = "200";
                return staff;
            }
            catch (Exception e)
            {
                throw e;
                stcode = "400";
            }
        }

        public string InsertStaff(Staff staff)
        {
            string stcode = string.Empty;
            try
            {
                _context.Staffs.Add(staff);
                _context.SaveChanges();
                stcode = "200";

            }
            catch (Exception e)
            {
                stcode = "400";
            }
            return stcode;

        }

        public void SaveStaff(Staff staff)
        {
            _context.SaveChanges();
        }

        public string UpdateStaff(Staff staff)
        {
            string stcode = string.Empty;
            try
            {
                _context.Staffs.Update(staff);
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
