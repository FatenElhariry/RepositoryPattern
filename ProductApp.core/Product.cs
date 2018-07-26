using System.ComponentModel.DataAnnotations;

namespace ProductApp.core
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }
        public bool inStock { get; set; }
    }
}
