using System.ComponentModel.DataAnnotations.Schema;

namespace ECom.Models.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PicturePath { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double Stock { get; set; }
        public Units Units { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}