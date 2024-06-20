namespace LabWebApp.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;  // Provide default value
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;  // Provide default value
    }
}
