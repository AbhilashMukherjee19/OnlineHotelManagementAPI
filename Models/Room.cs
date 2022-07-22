using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineHotelManagementAPI.Models
{
    public class Room
    {
        [Key]
        [DataType("int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int room_id { get; set; }

        [Required]
        public string room_type { get; set; }


        [DataType(DataType.Date)]
        [Required(ErrorMessage = "MM/DD/YYYY Format")]
        [Display(Name = "Check-in Date")]
        public DateTime check_in { get; set; }


        [DataType(DataType.Date)]
        [Required(ErrorMessage = "MM/DD/YYYY Format")]
        [Display(Name = "Check-out Date")]
        public DateTime check_out { get; set; }


        [Required(ErrorMessage = "Either Reserved or unreserved")]
        [Display(Name = "Status of the room")]
        public string status { get; set; }

        [Required]
        public int rateId { get; set; }
        [ForeignKey("rateId")]
        public Rate Rate { get; set; }
    }
}
