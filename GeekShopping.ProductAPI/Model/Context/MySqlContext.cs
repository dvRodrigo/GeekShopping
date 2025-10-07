using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }
      
        public MySqlContext()
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Camiseta",
                Price = new decimal(79.90),
                Description = "Camiseta do curso de ASP.NET Core Web API",
                CategoryName = "Roupas",
                ImageUrl = "https://raw.githubusercontent.com/GeekShopping/GeekShopping/master/Images/Products/camiseta.png"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Caneca",
                Price = new decimal(29.90),
                Description = "Caneca do curso de ASP.NET Core Web API",
                CategoryName = "Acessórios",
                ImageUrl = "https://raw.githubusercontent.com/GeekShopping/GeekShopping/master/Images/Products/caneca.png"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Moleton",
                Price = new decimal(119.90),
                Description = "Moleton do curso de ASP.NET Core Web API",
                CategoryName = "Roupas",
                ImageUrl = "https://raw.githubusercontent.com/GeekShopping/GeekShopping/master/Images/Products/moletom.png"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Mousepad",
                Price = new decimal(19.90),
                Description = "Mousepad do curso de ASP.NET Core Web API",
                CategoryName = "Acessórios",
                ImageUrl = "https://raw.githubusercontent.com/GeekShopping/GeekShopping/master/Images/Products/mousepad.png"
            }); 

            base.OnModelCreating(modelBuilder);
        }
    }
}
