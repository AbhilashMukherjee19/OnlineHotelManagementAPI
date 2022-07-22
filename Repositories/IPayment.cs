using OnlineHotelManagementAPI.Models;

namespace OnlineHotelManagementAPI.Repositories
{
    public interface IPayment
    {
        List<Payment> GetAllPayment();
        //string GetStaffById(int Id);
        string InsertPayment(Payment payment);
        string UpdatePayment(Payment payment);
        //string DeleteStaff(int Id);
        void SavePayment(Payment payment);
    }
}
