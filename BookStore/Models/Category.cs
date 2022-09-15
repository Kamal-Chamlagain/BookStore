namespace BookStore.Models
{
    public class Category
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
