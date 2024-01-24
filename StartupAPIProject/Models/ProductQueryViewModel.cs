using StartupAPIProject.Infrastructure.EntityModel;

namespace StartupAPIProject.Models
{
    public class ProductQueryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal PriceUnit { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
