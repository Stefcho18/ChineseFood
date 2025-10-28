using System.ComponentModel.DataAnnotations;

namespace ChineseFood.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Product> FoodItems { get; set; }
    }
}
