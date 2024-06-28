using System.ComponentModel.DataAnnotations;

namespace _13._06.Models
{
    public class Product
    {
        [Required]
        public string? Title { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
