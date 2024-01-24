using Microsoft.EntityFrameworkCore;
using StartupAPIProject.Infrastructure.EntityModel;

namespace StartupAPIProject.Infrastructure.Context
{
    public class StartupDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public StartupDbContext(DbContextOptions<StartupDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("StartupDatabase"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed initial data
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Image = "test.jpg", Name = "Apple", Description = "Apple, IOS", CreatedDate = DateTime.UtcNow },
                new Category { Id = 2, Image = "test.jpg", Name = "Samsung", Description = "Samsung, OneUI", CreatedDate = DateTime.UtcNow.AddDays(-1) },
                new Category { Id = 3, Image = "test.jpg", Name = "Xiaomi", Description = "Redmi", CreatedDate = DateTime.UtcNow.AddDays(-2) },
                new Category { Id = 4, Image = "test.jpg", Name = "Oppo", Description = "Android", CreatedDate = DateTime.UtcNow.AddDays(-3) },
                new Category { Id = 5, Image = "test.jpg", Name = "Realme", Description = "Android", CreatedDate = DateTime.UtcNow.AddDays(-4) }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id=1,CategoryId = 1, Image = "product.jpeg", CategoryName = "Apple", Name = "Apple", Description = "Apple, IOS", CreatedDate = DateTime.UtcNow },
                new Product { Id=2,CategoryId = 2, Image = "product.jpeg", CategoryName = "Samsung", Name = "Samsung", Description = "Samsung, OneUI", CreatedDate = DateTime.UtcNow.AddDays(-1) },
                new Product { Id=3,CategoryId = 3, Image = "product.jpeg", CategoryName = "Xiaomi", Name = "Xiaomi", Description = "Redmi", CreatedDate = DateTime.UtcNow.AddDays(-2) },
                new Product { Id=4,CategoryId = 4, Image = "product.jpeg", CategoryName = "Oppo", Name = "Oppo", Description = "Android", CreatedDate = DateTime.UtcNow.AddDays(-3) },
                new Product { Id=5,CategoryId = 5, Image = "product.jpeg", CategoryName = "Realme", Name = "Realme", Description = "Android", CreatedDate = DateTime.UtcNow.AddDays(-4) }
            );
            //Fluent API for Product and Category relationship
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Category>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id);

            base.OnModelCreating(modelBuilder);
        }
        //Define DbSet for Product and Category
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
