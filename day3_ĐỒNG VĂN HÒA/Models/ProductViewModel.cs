namespace day3_ĐỒNG_VĂN_HÒA.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public string? CategoryName { get; set; }
    }
}