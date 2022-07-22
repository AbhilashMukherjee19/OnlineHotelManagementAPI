using OnlineHotelManagementAPI.Models;

namespace OnlineHotelManagementAPI.Repositories
{
    public interface IReservation
    {
        List<Reservation> GetAllReservation();
        Reservation GetReservationById(int Id);
        string InsertReservation(Reservation reservation);
        string UpdateReservation(Reservation reservation);
        string DeleteReservation(int reservation);
        //void SaveInventory(Inventory inventory);
    }
}
