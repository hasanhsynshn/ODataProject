namespace StartupAPIProject.Infrastructure.EntityModel
{
    public class Category:BaseModel<int>
    {
        public Category()
        {
        }
        public Category(int id, string name, string description, string image)
        {
            Id= id;
            Name = name;
            Description = description;
            Image = image;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public virtual List<Product>? Products { get; set; }
    }
}
