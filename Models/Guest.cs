using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineHotelManagementAPI.Models
{
    public class Guest
    {
        [Key]
        [DataType("int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GuestId { get; set; }
        //Guest//

        [Required(ErrorMessage = "Name cannot be empty")]
        [DataType("varchar(25)")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [DataType("varchar(255)")]
        [StringLength(255, ErrorMessage = "Must be between 10 and 255 characters", MinimumLength = 5)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone Number cannot be empty")]
        [DataType("varchar(10)")]
        [MinLength(10, ErrorMessage = "Phone number cannot be last be 10")]
        public string PhnNumber { get; set; }

        [Required(ErrorMessage = "Gender cannot be empty")]
        [DataType("varchar(10)")]
        public string gender { get; set; }

        //[ForeignKey("guestId")]
        //public ICollection<Reservation> Reservations { get; set; }

        [Required]
        public int roomId { get; set; }
        [ForeignKey("roomId")]
        public Room Room { get; set; }
    }
}
