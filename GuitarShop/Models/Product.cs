namespace GuitarShop.Models
{
    // Generic class call Product with setters and getters such as name and price.
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Slug => Name.Replace(' ', '-');
    }
}