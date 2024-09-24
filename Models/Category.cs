namespace Task2.Models
{
    public class Category 
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Type { get; set; } //1-income 2-outcome
    }
}
