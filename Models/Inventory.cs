using System.ComponentModel.DataAnnotations;

namespace OnlineHotelManagementAPI.Models
{
    public class Inventory
    {
        [Key]
        [DataType("int")]
        public int Id { get; set; }
        //public int InventoryId { get; set; }


        [DataType("Varchar(30)")]
        [Required(ErrorMessage = "Please enter inventory name"), MaxLength(10), MinLength(3)]
        [Display(Name = "Item Name")]
        public string InventoryName { get; set; }


        [Required(ErrorMessage = "Please enter inventory name")]
        [Display(Name = "Quantity of each item")]
        public int Quantity { get; set; }


        [Required(ErrorMessage = "Please enter price")]
        [Display(Name = "Price of each item")]
        public double Price { get; set; }
    }
}
