using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineHotelManagementAPI.Models
{
    public class Payment
    {
        [Key]
        [DataType("int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentID { get; set; }


        //[Required]
        //public int GuestId { get; set; }
        //[ForeignKey("GuestId")]
        //public Guest Guest { get; set; }


        [DataType("Varchar(30)")]
        [StringLength(255, ErrorMessage = "Must be between 10 and 255 characters", MinimumLength = 5)]
        [Display(Name = " Card Holder Name")]
        public string CardholderName { get; set; }


        [DataType("varchar(16)")]
        [MinLength(16, ErrorMessage = "Please enter the card number")]
        [Required(ErrorMessage = "Please enter a valid Card Number")]
        [Display(Name = "Card Number")]
        public long CardNumber { get; set; }



        //public int rateId { get; set; }
        //[ForeignKey("rateId")]
        //public Rate Rate { get; set; }
    }
}
