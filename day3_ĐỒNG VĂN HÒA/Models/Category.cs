using System.ComponentModel.DataAnnotations;
namespace day3_ĐỒNG_VĂN_HÒA.Models
{
    public class Category
    {
        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Id is required")]
        [StringLength(100, MinimumLength =2, ErrorMessage = "tên danh mục phải từ 2 đến 100 kí tự")]
        public string? Name { get; set; } = string.Empty;
        public List<Product>? product
        {
            get; set;
        }
    }
}
