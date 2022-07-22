using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineHotelManagementAPI.Models
{
    public class Rate
    {
        [Key]
        [DataType("int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int rate_id { get; set; }


        [Required(ErrorMessage = "Please number of days")]
        [Display(Name = "Number of Days")]
        public int No_of_Days { get; set; }


        //[Required(ErrorMessage = "Please enter the RoomId")]
        //[Display(Name = "Room ID")]
        //public int roomId { get; set; }
        //[ForeignKey("roomId")]
        //public Room Room { get; set; }


        [Required(ErrorMessage = "Please enter a numeric value")]
        public double ExtensionPrice { get; set; }


        [Required(ErrorMessage = "Please enter a numeric value")]
        public double PerNightPrice { get; set; }


        [Required(ErrorMessage = "Please enter the total amount")]
        public double TotalAmount { get; set; }


        //[Required]
        //public int paymentId { get; set; }
        //[ForeignKey("paymentId")]
        //public Payment Payment { get; set; }

    }
}
