using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Product Id is Required")]
        [Display(Name = "ProductId")]

        public int? ProductId { get; set; }
        [Required(ErrorMessage = "Product Name is Required")]

        public string? ProductName { get; set; }
        [Required(ErrorMessage = "Category Name is Required")]

        public string CategoryName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Manufacturer is Required")]

        public string Manufacturer { get; set; } = String.Empty;
        [Required(ErrorMessage = "Price is Required")]

        public int? Price { get; set; }
    }
}
