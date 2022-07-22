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

        public string DeleteReservation(int reservation)
        {
            string msg = "";
            Reservation deleteReservation = _context.Reservations.Find(reservation);
            {
                _context.Reservations.Remove(deleteReservation);
                _context.SaveChanges();
                msg = "Deleted";
            }
            return msg;
        }

        public List<Reservation> GetAllReservation()
        {
            List<Reservation> reservation = _context.Reservations.ToList();
            return reservation;
        }

        public Reservation GetReservationById(int Id)
        {
            Reservation reservation;
            string stcode = string.Empty;
            try
            {


                reservation = _context.Reservations.Find(Id);
                _context.SaveChanges();
                stcode = "200";
                return reservation;
            }
            catch (Exception e)
            {
                throw e;
                stcode = "400";
            }

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
