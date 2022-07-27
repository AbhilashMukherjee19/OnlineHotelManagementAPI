using OnlineHotelManagementAPI.Models;

namespace OnlineHotelManagementAPI.Repositories
{
    public class ReservationRepo : IReservation
    {
        private HotelContext _context;

        public ReservationRepo(HotelContext context)
        {
            _context = context;
        }

        public string DeleteReservation(int id)
        {
            string stcode = string.Empty;
            try
            {
                var reservation = _context.Reservations.Find(id);
                if (reservation != null)
                {
                    _context.Reservations.Remove(reservation);
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

        public List<Reservation> GetAllReservation()
        {
            List<Reservation> reservation = _context.Reservations.ToList();
            return reservation;
        }

        public string GetReservationById(int Id)
        {
            Reservation reservation;
            string stcode = string.Empty;
            try
            {
                reservation = _context.Reservations.Find(Id);
                if (reservation != null)
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

        public string InsertReservation(Reservation reservation)
        {
            string stcode = string.Empty;
            try
            {
                _context.Reservations.Add(reservation);
                _context.SaveChanges();
                stcode = "200";

            }
            catch (Exception e)
            {
                stcode = "400";
            }
            return stcode;
        }

        //public void SaveInventory(Inventory inventory)
        //{
        //    _context.SaveChanges();
        //}

        public string UpdateReservation(Reservation reservation)
        {
            string stcode = string.Empty;
            try
            {
                _context.Reservations.Update(reservation);
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
