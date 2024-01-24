namespace StartupAPIProject.Infrastructure.EntityModel
{
    public class Product : BaseModel<int>
    {
        public Product()
        {
          
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal PriceUnit { get; set; }

        public Category Category { get; set; }

    }
}



