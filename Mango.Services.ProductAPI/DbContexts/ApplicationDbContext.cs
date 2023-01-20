using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        //Seeding the Database with DummyData 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Samosa",
                Price = 15,
                Description = "Delicious Meal",
                ImageUrl = "https://www.istockphoto.com/photo/group-of-sweet-and-salty-snacks-perfect-for-binge-watching-gm1149135424-310579769",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Panerr Tikka",
                Price = 15.24,
                Description = "Delicious Meal to the core",
                ImageUrl = "https://www.istockphoto.com/photo/group-of-sweet-and-salty-snacks-perfect-for-binge-watching-gm1149135424-310579769",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sweet Pie",
                Price = 10.99,
                Description = "Delicious Meal",
                ImageUrl = "https://www.istockphoto.com/photo/group-of-sweet-and-salty-snacks-perfect-for-binge-watching-gm1149135424-310579769",
                CategoryName = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Chicken Burger",
                Price = 15,
                Description = "Delicious Snacks to the core",
                ImageUrl = "https://www.istockphoto.com/photo/group-of-sweet-and-salty-snacks-perfect-for-binge-watching-gm1149135424-310579769",
                CategoryName = "Appetizer"
            });
        }
    }

}
