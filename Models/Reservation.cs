using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineHotelManagementAPI.Models
{
    public class Reservation
    {
        [Key]
        [DataType("int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DataType("int")]
        public int no_of_children { get; set; }

        [DataType("int")]
        [Required(ErrorMessage = "Number of adults cannot be empty")]
        public int no_of_adults { get; set; }

        [DataType("date")]
        [Required(ErrorMessage = "Checkin date cannot be empty")]
        public string chekin_date { get; set; }

        [DataType("date")]
        [Required(ErrorMessage = "Checkout date cannot be empty")]
        public string checkout_date { get; set; }

        [DataType("int")]
        [Required(ErrorMessage = "Number of rooms cannot be empty")]
        public string no_of_rooms { get; set; }

        [Required(ErrorMessage = "Status cannot be empty")]
        public string status { get; set; }

        [DataType("decimal")]
        [Required(ErrorMessage = "Advance payment cannot be empty")]
        public double advance_payment { get; set; }

        [Required(ErrorMessage = "Phone Number cannot be empty")]
        [DataType("varchar(10)")]
        [MinLength(10, ErrorMessage = "Phone number cannot less than 10")]
        public string PhnNumber { get; set; }

        [Required]
        public int guestId { get; set; }
        [ForeignKey("guestId")]
        public Guest Guest { get; set; }
    }
}
