using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineHotelManagementAPI.Models
{
    public class Staff
    {
        [Key]
        [DataType("int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StaffId { get; set; }


        [DataType("Varchar(30)")]
        [Required(ErrorMessage = "Please enter name"), MaxLength(30), MinLength(3)]
        [Display(Name = " Name")]
        public string StaffName { get; set; }


        [Required(ErrorMessage = "Enter address")]
        [DataType("Varchar(255)")]
        [StringLength(255, ErrorMessage = "Must be between 10 and 255 characters", MinimumLength = 5)]
        [Display(Name = "Staff Address")]
        public string Address { get; set; }


        [DataType("Nvarchar(20)")]
        [Required(ErrorMessage = "Please enter NIC"), MaxLength(20), MinLength(12)]
        [Display(Name = " NIC")]
        public string NIC { get; set; }


        [Required(ErrorMessage = "Enter salary")]
        [Display(Name = "Staff Salary")]
        public double Salary { get; set; }

        [Required(ErrorMessage = "Enter Age")]
        [Range(20, 60, ErrorMessage = "Age must satisfy the range")]
        [Display(Name = "Staff Age")]
        public int Age { get; set; }


        [Required(ErrorMessage = "Enter Occupation")]
        [Display(Name = "Occupation")]
        public string Occupation { get; set; }


        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email ID")]
        [MinLength(5, ErrorMessage = "Minimum 5 characters")]
        //[EmailAddress(ErrorMessage = "Enter valid email")]
        //[RegularExpression(@"^\w+([-+.']\w+)@\w+([-.]\w+)\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
