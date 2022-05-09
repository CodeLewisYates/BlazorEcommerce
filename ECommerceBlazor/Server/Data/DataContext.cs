
namespace ECommerceBlazor.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "85 Inch Smart TV UHD (4k)",
                    Description = "An 85\" smart tv with all the functionality you could think of, watch your favourite films and shows in 4k!",
                    ImageUrl = "https://www.sencor.com/Sencor/media/content/Products/SLE-55US800TCSB-diagonal.jpg",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "Lava Lamp",
                    Description = "Sparkly lava lamp to add a nice effect to any room",
                    ImageUrl = "https://geppettostoybox.com/wp-content/uploads/2020/11/Glitter-Lava-Lamp.jpg",
                    Price = 7.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Horse",
                    Description = "Why not buy a horse to keep you company, very friendly, eats a lot",
                    ImageUrl = "https://www.yourhorse.co.uk/wp-content/uploads/image-asset.jpg.webp",
                    Price = 5.00m
                }
            );
        }

        public DbSet<Product> Products { get; set; }
    }
}
