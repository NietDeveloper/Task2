using System.ComponentModel.DataAnnotations.Schema;

namespace Task2.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;   
        public int CategoryId { get; set; }

        [NotMapped]
        public Category Category { get; set; } = null!;
        
        public  int Sum { get; set; }
        public string? Comment { get; set; }

        [NotMapped]
        public List<Category> Categories { get; set; } = new();
    }
}
