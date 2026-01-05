using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace website.Models
{
    public class WebDbContext : DbContext
    {
        public WebDbContext(DbContextOptions<WebDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Users> Users { get; set; } = null!;
        public DbSet<Cart> Carts { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Banner> Banners { get; set; } = null!;
        public DbSet<Slider> Sliders { get; set; } = null!;
        public DbSet<PageContent> PageContents { get; set; } = null!;

        public DbSet<ContactMessage> ContactMessages { get; set; }

        public DbSet<Review> Reviews { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<NewAddition> NewAdditions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Decimal precision
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Order>()
                .Property(o => o.TotalPrice)
                .HasPrecision(18, 2);

            // Optional: Default Status
            modelBuilder.Entity<Order>()
                .Property(o => o.Status)
                .HasDefaultValue("Pending");
            // Decimal precision
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Order>()
                .Property(o => o.TotalPrice)
                .HasPrecision(18, 2);

            // Optional: Default Status
            modelBuilder.Entity<Order>()
                .Property(o => o.Status)
                .HasDefaultValue("Pending");

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Beds", ImageUrl = "/images/b1.jpg", BannerImageUrl = "/images/bed1.jpg", Description = "Comfortable and stylish beds for your bedroom" },
                new Category { Id = 2, Name = "Sofas", ImageUrl = "/images/s1.jpg", BannerImageUrl = "/images/Sofas.jpg", Description = "Comfortable and stylish beds for your bedroom" },
                new Category { Id = 3, Name = "Chairs", ImageUrl = "/images/c1.jpg", BannerImageUrl = "/images/ch.jpg", Description = "Elegant chairs for dining and living spaces" },
                new Category { Id = 4, Name = "Lamps", ImageUrl = "/images/l1.jpg", BannerImageUrl = "/images/lamp.jpg", Description = "Stylish lighting to brighten your home" },
                new Category { Id = 5, Name = "Mirrors", ImageUrl = "/images/m1.jpg", BannerImageUrl = "/images/mi.jpg", Description = "Decorative mirrors for every room" },
                new Category { Id = 6, Name = "Decor Items", ImageUrl = "/images/de1.jpg", BannerImageUrl = "/images/di.jpg", Description = "Beautiful decor items to enhance your space" },
                new Category { Id = 7, Name = "Dining Tables", ImageUrl = "/images/d1.jpg", BannerImageUrl = "/images/dining.jpg", Description = "Elegant dining tables for family meals" },
                new Category { Id = 8, Name = "Tables", ImageUrl = "/images/t1.jpg", BannerImageUrl = "/images/tab.jpg", Description = "Functional tables for living and work spaces" },
            new Category { Id = 9, Name = "Table and Chairs", ImageUrl = "/images/bt1.jpg", BannerImageUrl = "/images/ktb.jpg", Description = "Functional tables for living and work spaces " },
    new Category { Id = 10, Name = "Modern Beds", ImageUrl = "/images/bb1.jpg", BannerImageUrl = "/images/kb.jpg", Description = "Comfortable and stylish beds for your bedroom" },
    new Category { Id = 11, Name = "Kids Wardrobe", ImageUrl = "/images/bd1.jpg", BannerImageUrl = "/images/kd.jpg", Description = "A spacious and sturdy wardrobe specially designed for kids. Features multiple shelves and hanging space to keep clothes and toys organized, with a fun and colorful design." },
    new Category { Id = 12, Name = "Wooden Rocker", ImageUrl = "/images/br1.jpg", BannerImageUrl = "/images/kr.jpg", Description = "A classic wooden rocker designed for comfort and style. Perfect for relaxing in your living room or porch, crafted from high-quality wood for durability." }
                );
            modelBuilder.Entity<Product>().HasData(
// Beds (CategoryId = 1)
new Product { Id = 1, Name = "Bed b1", Description = "Comfortable bed", Color = "White", Price = 35000, Stock = 10, CategoryId = 1, ImageUrl = "/images/b1.jpg" },
new Product { Id = 2, Name = "Bed b2", Description = "Stylish bed", Color = "Green", Price = 40000, Stock = 8, CategoryId = 1, ImageUrl = "/images/b2.jpg" },
new Product { Id = 3, Name = "Bed b3", Description = "Luxury bed", Color = "Beige", Price = 50000, Stock = 5, CategoryId = 1, ImageUrl = "/images/b3.jpg" },
new Product { Id = 4, Name = "Bed b4", Description = "Modern bed", Color = "Brown", Price = 45000, Stock = 7, CategoryId = 1, ImageUrl = "/images/b4.jpg" },
new Product { Id = 5, Name = "Bed b5", Description = "Classic bed", Color = "White", Price = 38000, Stock = 6, CategoryId = 1, ImageUrl = "/images/b5.jpg" },
new Product { Id = 6, Name = "Bed b6", Description = "Cozy bed", Color = "Pink", Price = 42000, Stock = 4, CategoryId = 1, ImageUrl = "/images/b6.jpg" },
new Product { Id = 7, Name = "Bed b7", Description = "Comfort bed", Color = "Grey", Price = 39000, Stock = 8, CategoryId = 1, ImageUrl = "/images/b7.jpg" },
new Product { Id = 8, Name = "Bed b8", Description = "Elegant bed", Color = "White", Price = 46000, Stock = 5, CategoryId = 1, ImageUrl = "/images/b8.jpg" },
new Product { Id = 9, Name = "Bed b9", Description = "Modern bed", Color = "Grey", Price = 47000, Stock = 3, CategoryId = 1, ImageUrl = "/images/b9.jpg" },
new Product { Id = 10, Name = "Bed b10", Description = "Luxury bed", Color = "Beige", Price = 48000, Stock = 4, CategoryId = 1, ImageUrl = "/images/b10.jpg" },
new Product { Id = 11, Name = "Bed b11", Description = "Classic bed", Color = "Pink", Price = 43000, Stock = 6, CategoryId = 1, ImageUrl = "/images/b11.jpg" },
new Product { Id = 12, Name = "Bed b12", Description = "Stylish bed", Color = "Beige", Price = 44000, Stock = 5, CategoryId = 1, ImageUrl = "/images/b12.jpg" },

// Sofas (CategoryId = 2)
new Product { Id = 13, Name = "Sofa s1", Description = "Soft sofa", Color = "Pink", Price = 25000, Stock = 7, CategoryId = 2, ImageUrl = "/images/s1.jpg" },
new Product { Id = 14, Name = "Sofa s2", Description = "Elegant sofa", Color = "Blue", Price = 27000, Stock = 4, CategoryId = 2, ImageUrl = "/images/s2.jpg" },
new Product { Id = 15, Name = "Sofa s3", Description = "Modern sofa", Color = "Green", Price = 30000, Stock = 5, CategoryId = 2, ImageUrl = "/images/s3.jpg" },
new Product { Id = 16, Name = "Sofa s4", Description = "Stylish sofa", Color = "Black/White", Price = 32000, Stock = 6, CategoryId = 2, ImageUrl = "/images/s4.jpg" },
new Product { Id = 17, Name = "Sofa s5", Description = "Cozy sofa", Color = "Beige", Price = 29000, Stock = 3, CategoryId = 2, ImageUrl = "/images/s5.jpg" },
new Product { Id = 18, Name = "Sofa s6", Description = "Comfortable sofa", Color = "Green", Price = 31000, Stock = 4, CategoryId = 2, ImageUrl = "/images/s6.jpg" },
new Product { Id = 19, Name = "Sofa s7", Description = "Modern sofa", Color = "White", Price = 28000, Stock = 6, CategoryId = 2, ImageUrl = "/images/s7.jpg" },
new Product { Id = 20, Name = "Sofa s8", Description = "Elegant sofa", Color = "Grey", Price = 30000, Stock = 5, CategoryId = 2, ImageUrl = "/images/s8.jpg" },
new Product { Id = 21, Name = "Sofa s9", Description = "Stylish sofa", Color = "Blue", Price = 33000, Stock = 4, CategoryId = 2, ImageUrl = "/images/s9.jpg" },
new Product { Id = 22, Name = "Sofa s10", Description = "Cozy sofa", Color = "Purple", Price = 34000, Stock = 3, CategoryId = 2, ImageUrl = "/images/s10.jpg" },
new Product { Id = 23, Name = "Sofa s11", Description = "Round sofa", Color = "Pink", Price = 35000, Stock = 2, CategoryId = 2, ImageUrl = "/images/s11.jpg" },
new Product { Id = 24, Name = "Sofa s12", Description = "Comfort sofa", Color = "White", Price = 32000, Stock = 5, CategoryId = 2, ImageUrl = "/images/s12.jpg" },
new Product { Id = 25, Name = "Sofa s13", Description = "Luxury sofa", Color = "Beige", Price = 36000, Stock = 4, CategoryId = 2, ImageUrl = "/images/s13.jpg" },

// Chairs (CategoryId = 3)
new Product { Id = 26, Name = "Chair c1", Description = "Elegant chair", Color = "White", Price = 7000, Stock = 10, CategoryId = 3, ImageUrl = "/images/c1.jpg" },
new Product { Id = 27, Name = "Chair c2", Description = "Comfort chair", Color = "Brown", Price = 7500, Stock = 8, CategoryId = 3, ImageUrl = "/images/c2.jpg" },
new Product { Id = 28, Name = "Chair c3", Description = "Stylish chair", Color = "Grey", Price = 8000, Stock = 6, CategoryId = 3, ImageUrl = "/images/c3.jpg" },
new Product { Id = 29, Name = "Chair c4", Description = "Modern chair", Color = "Blue", Price = 8200, Stock = 5, CategoryId = 3, ImageUrl = "/images/c4.jpg" },
new Product { Id = 30, Name = "Chair c5", Description = "Round chair", Color = "White", Price = 8500, Stock = 7, CategoryId = 3, ImageUrl = "/images/c5.jpg" },
new Product { Id = 31, Name = "Chair c6", Description = "Unique chair", Color = "Grey", Price = 8700, Stock = 4, CategoryId = 3, ImageUrl = "/images/c6.jpg" },
new Product { Id = 32, Name = "Chair c7", Description = "Stylish chair", Color = "White", Price = 8800, Stock = 6, CategoryId = 3, ImageUrl = "/images/c7.jpg" },
new Product { Id = 33, Name = "Chair c8", Description = "Comfortable chair", Color = "Beige", Price = 9000, Stock = 5, CategoryId = 3, ImageUrl = "/images/c8.jpg" },
new Product { Id = 34, Name = "Chair c9", Description = "Modern chair", Color = "White", Price = 9100, Stock = 6, CategoryId = 3, ImageUrl = "/images/c9.jpg" },
new Product { Id = 35, Name = "Chair c10", Description = "Round chair", Color = "Beige", Price = 9200, Stock = 4, CategoryId = 3, ImageUrl = "/images/c10.jpg" },
new Product { Id = 36, Name = "Chair c11", Description = "Stylish chair", Color = "White", Price = 9300, Stock = 5, CategoryId = 3, ImageUrl = "/images/c11.jpg" },
new Product { Id = 37, Name = "Chair c12", Description = "Comfort chair", Color = "Beige", Price = 9400, Stock = 3, CategoryId = 3, ImageUrl = "/images/c12.jpg" },
// … Continue for Lamps (l1-l10), Mirrors (m1-m8), Decor Items (de1-de10), Dining Tables (d1-d12), Tables (t1-t12)
new Product { Id = 100, Name = "Lamp l1", Description = "Modern lamp", Color = "White", Price = 4500, Stock = 10, CategoryId = 4, ImageUrl = "/images/l1.jpg" },
new Product { Id = 101, Name = "Lamp l2", Description = "Table lamp", Color = "Black", Price = 4200, Stock = 8, CategoryId = 4, ImageUrl = "/images/l2.jpg" },
new Product { Id = 102, Name = "Lamp l3", Description = "Classic lamp", Color = "Gold", Price = 5000, Stock = 6, CategoryId = 4, ImageUrl = "/images/l3.jpg" },
new Product { Id = 103, Name = "Lamp l4", Description = "Elegant lamp", Color = "Green", Price = 5500, Stock = 5, CategoryId = 4, ImageUrl = "/images/l4.jpg" },
new Product { Id = 104, Name = "Lamp l5", Description = "Modern floor lamp", Color = "Grey", Price = 6000, Stock = 7, CategoryId = 4, ImageUrl = "/images/l5.jpg" },
new Product { Id = 105, Name = "Lamp l6", Description = "Stylish lamp", Color = "Gold", Price = 5800, Stock = 4, CategoryId = 4, ImageUrl = "/images/l6.jpg" },
new Product { Id = 106, Name = "Lamp l7", Description = "Wall lamp", Color = "White", Price = 6200, Stock = 6, CategoryId = 4, ImageUrl = "/images/l7.jpg" },
new Product { Id = 107, Name = "Lamp l8", Description = "Designer lamp", Color = "Beige", Price = 6500, Stock = 5, CategoryId = 4, ImageUrl = "/images/l8.jpg" },
new Product { Id = 108, Name = "Lamp l9", Description = "Luxury lamp", Color = "Black", Price = 7000, Stock = 4, CategoryId = 4, ImageUrl = "/images/l9.jpg" },
new Product { Id = 109, Name = "Lamp l10", Description = "Premium lamp", Color = "White", Price = 7200, Stock = 3, CategoryId = 4, ImageUrl = "/images/l10.jpg" },


new Product { Id = 110, Name = "Mirror m1", Description = "Decorative mirror", Color = "White", Price = 5800, Stock = 5, CategoryId = 5, ImageUrl = "/images/m1.jpg" },
new Product { Id = 111, Name = "Mirror m2", Description = "Modern mirror", Color = "Grey", Price = 6000, Stock = 6, CategoryId = 5, ImageUrl = "/images/m2.jpg" },
new Product { Id = 112, Name = "Mirror m3", Description = "Artistic mirror", Color = "White", Price = 6500, Stock = 4, CategoryId = 5, ImageUrl = "/images/m3.jpg" },
new Product { Id = 113, Name = "Mirror m4", Description = "Round mirror", Color = "Pink", Price = 6200, Stock = 5, CategoryId = 5, ImageUrl = "/images/m4.jpg" },
new Product { Id = 114, Name = "Mirror m5", Description = "Soft round mirror", Color = "White", Price = 7000, Stock = 3, CategoryId = 5, ImageUrl = "/images/m5.jpg" },
new Product { Id = 115, Name = "Mirror m6", Description = "Tall mirror", Color = "White", Price = 7500, Stock = 4, CategoryId = 5, ImageUrl = "/images/m6.jpg" },
new Product { Id = 116, Name = "Mirror m7", Description = "Full-length mirror", Color = "Black", Price = 7800, Stock = 4, CategoryId = 5, ImageUrl = "/images/m7.jpg" },
new Product { Id = 117, Name = "Mirror m8", Description = "Luxury mirror", Color = "Green", Price = 8200, Stock = 3, CategoryId = 5, ImageUrl = "/images/m8.jpg" },



new Product { Id = 118, Name = "Decor de1", Description = "Decor item", Color = "Gold", Price = 3000, Stock = 10, CategoryId = 6, ImageUrl = "/images/de1.jpg" },
new Product { Id = 119, Name = "Decor de2", Description = "Elegant decor", Color = "Beige", Price = 3500, Stock = 9, CategoryId = 6, ImageUrl = "/images/de2.jpg" },
new Product { Id = 120, Name = "Decor de3", Description = "Modern decor", Color = "Gold", Price = 3800, Stock = 8, CategoryId = 6, ImageUrl = "/images/de3.jpg" },
new Product { Id = 121, Name = "Decor de4", Description = "Stylish decor", Color = "Green", Price = 3600, Stock = 7, CategoryId = 6, ImageUrl = "/images/de4.jpg" },
new Product { Id = 122, Name = "Decor de5", Description = "Premium decor", Color = "Gold", Price = 4000, Stock = 6, CategoryId = 6, ImageUrl = "/images/de5.jpg" },
new Product { Id = 123, Name = "Decor de6", Description = "Vase decor", Color = "Cream", Price = 4200, Stock = 5, CategoryId = 6, ImageUrl = "/images/de6.jpg" },
new Product { Id = 124, Name = "Decor de7", Description = "Black decor set", Color = "Black", Price = 3800, Stock = 4, CategoryId = 6, ImageUrl = "/images/de7.jpg" },
new Product { Id = 125, Name = "Decor de8", Description = "Wood decor", Color = "Brown", Price = 4500, Stock = 6, CategoryId = 6, ImageUrl = "/images/de8.jpg" },
new Product { Id = 126, Name = "Decor de9", Description = "Silver vase", Color = "Silver", Price = 4800, Stock = 5, CategoryId = 6, ImageUrl = "/images/de9.jpg" },
new Product { Id = 127, Name = "Decor de10", Description = "Elegant decor item", Color = "Gold", Price = 5000, Stock = 3, CategoryId = 6, ImageUrl = "/images/de10.jpg" },

new Product { Id = 128, Name = "Dining Table d1", Description = "Round dining table", Color = "Beige", Price = 18000, Stock = 5, CategoryId = 7, ImageUrl = "/images/d1.jpg" },
new Product { Id = 129, Name = "Dining Table d2", Description = "Wood dining table", Color = "Brown", Price = 20000, Stock = 4, CategoryId = 7, ImageUrl = "/images/d2.jpg" },
new Product { Id = 130, Name = "Dining Table d3", Description = "Modern dining table", Color = "White", Price = 21000, Stock = 6, CategoryId = 7, ImageUrl = "/images/d3.jpg" },
new Product { Id = 131, Name = "Dining Table d4", Description = "Classic dining table", Color = "Grey", Price = 22000, Stock = 3, CategoryId = 7, ImageUrl = "/images/d4.jpg" },
new Product { Id = 132, Name = "Dining Table d5", Description = "Compact dining table", Color = "White", Price = 19000, Stock = 6, CategoryId = 7, ImageUrl = "/images/d5.jpg" },
new Product { Id = 133, Name = "Dining Table d6", Description = "Designer dining table", Color = "Black", Price = 24000, Stock = 2, CategoryId = 7, ImageUrl = "/images/d6.jpg" },
new Product { Id = 134, Name = "Dining Table d7", Description = "Stylish dining table", Color = "Beige", Price = 23000, Stock = 4, CategoryId = 7, ImageUrl = "/images/d7.jpg" },
new Product { Id = 135, Name = "Dining Table d8", Description = "Wood table", Color = "Brown", Price = 21000, Stock = 5, CategoryId = 7, ImageUrl = "/images/d8.jpg" },
new Product { Id = 136, Name = "Dining Table d9", Description = "Glass dining table", Color = "Silver", Price = 26000, Stock = 3, CategoryId = 7, ImageUrl = "/images/d9.jpg" },
new Product { Id = 137, Name = "Dining Table d10", Description = "Elegant table", Color = "White", Price = 25000, Stock = 2, CategoryId = 7, ImageUrl = "/images/d10.jpg" },
new Product { Id = 138, Name = "Dining Table d11", Description = "Luxury dining table", Color = "Gold", Price = 30000, Stock = 2, CategoryId = 7, ImageUrl = "/images/d11.jpg" },
new Product { Id = 139, Name = "Dining Table d12", Description = "Artistic table", Color = "Grey", Price = 27000, Stock = 3, CategoryId = 7, ImageUrl = "/images/d12.jpg" },

new Product { Id = 140, Name = "Table t1", Description = "Round table", Color = "White", Price = 9000, Stock = 7, CategoryId = 8, ImageUrl = "/images/t1.jpg" },
new Product { Id = 141, Name = "Table t2", Description = "Modern table", Color = "Beige", Price = 9500, Stock = 6, CategoryId = 8, ImageUrl = "/images/t2.jpg" },
new Product { Id = 142, Name = "Table t3", Description = "Wood table", Color = "Brown", Price = 9800, Stock = 5, CategoryId = 8, ImageUrl = "/images/t3.jpg" },
new Product { Id = 143, Name = "Table t4", Description = "Classic table", Color = "White", Price = 10000, Stock = 4, CategoryId = 8, ImageUrl = "/images/t4.jpg" },
new Product { Id = 144, Name = "Table t5", Description = "Decor table", Color = "Grey", Price = 10200, Stock = 5, CategoryId = 8, ImageUrl = "/images/t5.jpg" },
new Product { Id = 145, Name = "Table t6", Description = "Side table", Color = "White", Price = 11000, Stock = 4, CategoryId = 8, ImageUrl = "/images/t6.jpg" },
new Product { Id = 146, Name = "Table t7", Description = "Center table", Color = "Brown", Price = 12000, Stock = 4, CategoryId = 8, ImageUrl = "/images/t7.jpg" },
new Product { Id = 147, Name = "Table t8", Description = "Premium table", Color = "White", Price = 13000, Stock = 3, CategoryId = 8, ImageUrl = "/images/t8.jpg" },
new Product { Id = 148, Name = "Table t9", Description = "Luxury table", Color = "Black", Price = 15000, Stock = 3, CategoryId = 8, ImageUrl = "/images/t9.jpg" },
new Product { Id = 149, Name = "Table t10", Description = "Coffee table", Color = "White", Price = 14000, Stock = 4, CategoryId = 8, ImageUrl = "/images/t10.jpg" },
new Product { Id = 150, Name = "Table t11", Description = "Wood coffee table", Color = "Brown", Price = 13500, Stock = 5, CategoryId = 8, ImageUrl = "/images/t11.jpg" },
new Product { Id = 151, Name = "Table t12", Description = "Round center table", Color = "Gold", Price = 16000, Stock = 2, CategoryId = 8, ImageUrl = "/images/t12.jpg" },


new Product { Id = 171, Name = "Table Set 2", Description = "Elegant table set", Color = "Brown", Price = 35000, Stock = 5, CategoryId = 9, NewAdditionId = 1, ImageUrl = "/images/bt1.jpg" },
    new Product { Id = 172, Name = "Table Set 2", Description = "Stylish table set", Color = "Brown", Price = 38000, Stock = 5, CategoryId = 9, NewAdditionId = 1, ImageUrl = "/images/bt2.jpg" },
     new Product { Id = 173, Name = "Table Set 3", Description = "Elegant table set", Color = "Brown", Price = 35000, Stock = 5, CategoryId = 9, NewAdditionId = 1, ImageUrl = "/images/bt3.jpg" },
    new Product { Id = 174, Name = "Table Set 4", Description = "Stylish table set", Color = "Brown", Price = 38000, Stock = 5, CategoryId = 9, NewAdditionId = 1, ImageUrl = "/images/bt4.jpg" },
     new Product { Id = 175, Name = "Table Set 5", Description = "Elegant table set", Color = "Brown", Price = 35000, Stock = 5, CategoryId = 9, NewAdditionId = 1, ImageUrl = "/images/bt5.jpg" },
      new Product { Id = 176, Name = "Table Set 6", Description = "Elegant table set", Color = "Brown", Price = 35000, Stock = 5, CategoryId = 9, NewAdditionId = 1, ImageUrl = "/images/bt6.jpg" },
       new Product { Id = 177, Name = "Table Set 7", Description = "Elegant table set", Color = "Brown", Price = 35000, Stock = 5, CategoryId = 9, NewAdditionId = 1, ImageUrl = "/images/bt7.jpg" },
    new Product { Id = 178, Name = "Table Set 8", Description = "Stylish table set", Color = "Brown", Price = 38000, Stock = 5, CategoryId = 9, NewAdditionId = 1, ImageUrl = "/images/bt8.jpg" },
     new Product { Id = 179, Name = "Table Set 9", Description = "Elegant table set", Color = "Brown", Price = 35000, Stock = 5, CategoryId = 9, NewAdditionId = 1, ImageUrl = "/images/bt9.jpg" },
    new Product { Id = 180, Name = "Table Set 10", Description = "Stylish table set", Color = "Brown", Price = 38000, Stock = 5, CategoryId = 9, NewAdditionId = 1, ImageUrl = "/images/bt10.jpg" },





    // NewAdditionId = 2 (Modern Beds)
    new Product { Id = 181, Name = "Modern Bed 1", Description = "Comfortable modern bed", Color = "Brown", Price = 40000, Stock = 3, CategoryId = 10, NewAdditionId = 2, ImageUrl = "/images/bb1.jpg" },
    new Product { Id = 182, Name = "Modern Bed 2", Description = "Luxury modern bed", Color = "Brown", Price = 45000, Stock = 3, CategoryId = 10, NewAdditionId = 2, ImageUrl = "/images/bb3.jpg" },
     new Product { Id = 183, Name = "Modern Bed 3", Description = "Comfortable modern bed", Color = "Brown", Price = 40000, Stock = 3, CategoryId = 10, NewAdditionId = 2, ImageUrl = "/images/bb4.jpg" },
    new Product { Id = 184, Name = "Modern Bed 4", Description = "Luxury modern bed", Color = "Brown", Price = 45000, Stock = 3, CategoryId = 10, NewAdditionId = 2, ImageUrl = "/images/bb5.jpg" },
     new Product { Id = 185, Name = "Modern Bed 5", Description = "Comfortable modern bed", Color = "Brown", Price = 40000, Stock = 3, CategoryId = 10, NewAdditionId = 2, ImageUrl = "/images/bb6.jpg" },
    new Product { Id = 186, Name = "Modern Bed 6", Description = "Luxury modern bed", Color = "Brown", Price = 45000, Stock = 3, CategoryId = 10, NewAdditionId = 2, ImageUrl = "/images/bb7.jpg" },
     new Product { Id = 187, Name = "Modern Bed 7", Description = "Comfortable modern bed", Color = "Brown", Price = 40000, Stock = 3, CategoryId = 10, NewAdditionId = 2, ImageUrl = "/images/bb8.jpg" },
    new Product { Id = 188, Name = "Modern Bed 8", Description = "Luxury modern bed", Color = "Brown", Price = 45000, Stock = 3, CategoryId = 10, NewAdditionId = 2, ImageUrl = "/images/bb9.jpg" },
     new Product { Id = 189, Name = "Modern Bed 9", Description = "Comfortable modern bed", Color = "Brown", Price = 40000, Stock = 3, CategoryId = 10, NewAdditionId = 2, ImageUrl = "/images/bb10.jpg" },
    new Product { Id = 190, Name = "Modern Bed 10", Description = "Luxury modern bed", Color = "Brown", Price = 45000, Stock = 3, CategoryId = 10, NewAdditionId = 2, ImageUrl = "/images/bb11.jpg" },

    // NewAdditionId = 3 (Kids 
    new Product { Id = 191, Name = "Kids Wardrobe 1", Description = "Colorful kids wardrobe", Color = "Brown", Price = 12000, Stock = 1, CategoryId = 11, NewAdditionId = 3, ImageUrl = "/images/bd1.jpg" },
    new Product { Id = 192, Name = "Kids Wardrobe 2", Description = "Spacious kids wardrobe", Color = "Brown", Price = 15000, Stock = 1, CategoryId = 11, NewAdditionId = 3, ImageUrl = "/images/bd2.jpg" },
     new Product { Id = 193, Name = "Kids Wardrobe 3", Description = "Colorful kids wardrobe", Color = "Brown", Price = 12000, Stock = 1, CategoryId = 11, NewAdditionId = 3, ImageUrl = "/images/bd3.jpg" },
    new Product { Id = 194, Name = "Kids Wardrobe 4", Description = "Spacious kids wardrobe", Color = "Brown", Price = 15000, Stock = 1, CategoryId = 11, NewAdditionId = 3, ImageUrl = "/images/bd4.jpg" },
     new Product { Id = 195, Name = "Kids Wardrobe 5", Description = "Colorful kids wardrobe", Color = "Brown", Price = 12000, Stock = 1, CategoryId = 11, NewAdditionId = 3, ImageUrl = "/images/bd5.jpg" },
    new Product { Id = 196, Name = "Kids Wardrobe 6", Description = "Spacious kids wardrobe", Color = "Brown", Price = 15000, Stock = 1, CategoryId = 11, NewAdditionId = 3, ImageUrl = "/images/bd6.jpg" },
     new Product { Id = 197, Name = "Kids Wardrobe 7", Description = "Colorful kids wardrobe", Color = "Brown", Price = 12000, Stock = 1, CategoryId = 11, NewAdditionId = 3, ImageUrl = "/images/bb7.jpg" },
    new Product { Id = 198, Name = "Kids Wardrobe 8", Description = "Spacious kids wardrobe", Color = "Brown", Price = 15000, Stock = 1, CategoryId = 11, NewAdditionId = 3, ImageUrl = "/images/bd8.jpg" },
     new Product { Id = 199, Name = "Kids Wardrobe 9", Description = "Colorful kids wardrobe", Color = "Brown", Price = 12000, Stock = 1, CategoryId = 11, NewAdditionId = 3, ImageUrl = "/images/bd9.jpg" },
    new Product { Id = 200, Name = "Kids Wardrobe 10", Description = "Spacious kids wardrobe", Color = "Brown", Price = 15000, Stock = 1, CategoryId = 11, NewAdditionId = 3, ImageUrl = "/images/bd10.jpg" },

    // NewAdditionId = 4 (Wooden Rocker)
    new Product { Id = 201, Name = "Wooden Rocker 1", Description = "Classic wooden rocker", Color = "Brown", Price = 15000, Stock = 3, CategoryId = 12, NewAdditionId = 4, ImageUrl = "/images/br1.jpg" },
    new Product { Id = 202, Name = "Wooden Rocker 2", Description = "Comfortable wooden rocker", Color = "Brown", Price = 18000, Stock = 3, CategoryId = 12, NewAdditionId = 4, ImageUrl = "/images/br2.jpg" },
    new Product { Id = 203, Name = "Wooden Rocker 3", Description = "Classic wooden rocker", Color = "Brown", Price = 15000, Stock = 3, CategoryId = 12, NewAdditionId = 4, ImageUrl = "/images/br3.jpg" },
    new Product { Id = 204, Name = "Wooden Rocker 4", Description = "Comfortable wooden rocker", Color = "Brown", Price = 18000, Stock = 3, CategoryId = 12, NewAdditionId = 4, ImageUrl = "/images/br4.jpg" },
    new Product { Id = 205, Name = "Wooden Rocker 5", Description = "Classic wooden rocker", Color = "Brown", Price = 15000, Stock = 3, CategoryId = 12, NewAdditionId = 4, ImageUrl = "/images/br5.jpg" },
    new Product { Id = 206, Name = "Wooden Rocker 6", Description = "Comfortable wooden rocker", Color = "Brown", Price = 18000, Stock = 3, CategoryId = 12, NewAdditionId = 4, ImageUrl = "/images/br6.jpg" },
    new Product { Id = 207, Name = "Wooden Rocker 7", Description = "Classic wooden rocker", Color = "Brown", Price = 15000, Stock = 3, CategoryId = 12, NewAdditionId = 4, ImageUrl = "/images/br7.jpg" },
    new Product { Id = 208, Name = "Wooden Rocker 8", Description = "Comfortable wooden rocker", Color = "Brown", Price = 18000, Stock = 3, CategoryId = 12, NewAdditionId = 4, ImageUrl = "/images/br8.jpg" },
    new Product { Id = 209, Name = "Wooden Rocker 9", Description = "Classic wooden rocker", Color = "Brown", Price = 15000, Stock = 3, CategoryId = 12, NewAdditionId = 4, ImageUrl = "/images/br9.jpg" },
    new Product { Id = 210, Name = "Wooden Rocker 10", Description = "Comfortable wooden rocker", Color = "Brown", Price = 18000, Stock = 3, CategoryId = 12, NewAdditionId = 4, ImageUrl = "/images/br10.jpg" },







new Product { Id = 153, Name = "Chair c5", Description = "Round chair", Color = "White", Price = 8500, Stock = 7, CategoryId = 3, ImageUrl = "/images/c5.jpg", IsTrending = true },
new Product { Id = 154, Name = "Dining Table d10", Description = "Elegant table", Color = "White", Price = 25000, CategoryId = 7, Stock = 2, ImageUrl = "/images/d10.jpg", IsTrending = true },
new Product { Id = 155, Name = "Decor de6", Description = "Vase decor", Color = "Cream", Price = 4200, Stock = 5, CategoryId = 6, ImageUrl = "/images/de6.jpg", IsTrending = true },
new Product { Id = 156, Name = "Mirror m1", Description = "Decorative mirror", Color = "White", Price = 5800, Stock = 5, CategoryId = 5, ImageUrl = "/images/m1.jpg", IsTrending = true },
new Product { Id = 157, Name = "Table t9", Description = "Luxury table", Color = "Black", Price = 15000, Stock = 3, CategoryId = 8, ImageUrl = "/images/t9.jpg", IsTrending = true },
new Product { Id = 158, Name = "Sofa s13", Description = "Luxury sofa", Color = "Beige", Price = 36000, Stock = 4, CategoryId = 2, ImageUrl = "/images/s13.jpg", IsTrending = true },
new Product { Id = 159, Name = "Lamp l4", Description = "Elegant lamp", Color = "Green", Price = 5500, Stock = 5, CategoryId = 4, ImageUrl = "/images/l4.jpg", IsTrending = true },
new Product { Id = 160, Name = "Bed b9", Description = "Modern bed", Color = "Grey", Price = 47000, Stock = 3, CategoryId = 1, ImageUrl = "/images/b9.jpg", IsTrending = true },
new Product { Id = 161, Name = "Dining Table d11", Description = "Luxury dining table", Color = "Gold", Price = 30000, Stock = 2, CategoryId = 7, ImageUrl = "/images/d11.jpg", IsTrending = true },
new Product { Id = 162, Name = "Decor de10", Description = "Elegant decor item", Color = "Gold", Price = 5000, Stock = 3, CategoryId = 6, ImageUrl = "/images/de10.jpg", IsTrending = true }



);


            // ================= BANNERS =================
            modelBuilder.Entity<Banner>().HasData(
                // Admin Banners
                new Banner { Id = 1, ImageUrl = "/images/ba1.jpg", Page = "Admin" },
                new Banner { Id = 4, ImageUrl = "/images/ba1.jpg", Page = "User" }
            );

            modelBuilder.Entity<Slider>().HasData(
                    new Slider { Id = 1, ImageUrl = "/images/slider1.jpg" },
                    new Slider { Id = 2, ImageUrl = "/images/slider2.jpg" },
                    new Slider { Id = 3, ImageUrl = "/images/slider3.jpg" }
                );







            // ================== PageContent Seed ==================
            modelBuilder.Entity<PageContent>().HasData(
                new PageContent
                {
                    Id = 1,
                    PageName = "About",
                    Title = "About us",
                    Content = @"Welcome to our website! We are a dedicated team committed to providing the highest quality products to our customers. 
                    Our mission is to combine excellent service with affordable prices, ensuring every customer has a 
                    seamless shopping experience. We believe in transparency, trust, and building long-lasting relationships 
                    with our clients. From product selection to delivery, we ensure every step meets the highest standards.",
                    ImageUrl = "/images/ab1.jpg",

                },
                new PageContent
                {
                    Id = 2,
                    PageName = "Contact",
                    Title = "Contact Us",
                    Content = @"Have questions or need assistance? Our customer support team is here to help. 
                    You can reach us via email at support@example.com or call us at (123) 456-7890. 
                    Our office hours are Monday to Friday, 9 AM to 6 PM. We also provide live chat support for 
                    instant assistance during business hours. Your feedback is important to us and helps us improve.",
                    ImageUrl = "/images/co.jpg"
                },
                new PageContent
                {
                    Id = 3,
                    PageName = "Privacy Policy",
                    Title = "Privacy Policy",
                    Content = @"We value your privacy and are committed to protecting your personal information. 
                    Any data you provide is securely stored and used only for order processing and customer support. 
                    We do not sell, trade, or share your information with third parties without your consent. 
                    Our website uses cookies to enhance your browsing experience, and you can manage your preferences at any time.",
                    ImageUrl = "/images/pi.jpg"
                },
                  new PageContent
                  {
                      Id = 4,
                      PageName = "Delivery",
                      Title = "Delivery Information",
                      Content = @"We provide fast and reliable delivery services across the country. Orders are typically processed within 
                    24 hours and delivered within 3-7 business days, depending on your location. Free shipping is available 
                    for orders over $50. You can track your order at any time using our tracking system. 
                    In case of delays, our support team will notify you promptly.",
                      ImageUrl = "/images/de.jpg"
                  },
                new PageContent
                {
                    Id = 5,
                    PageName = "Reviews",
                    Title = "Customer Reviews",
                    Content = @"Our customers are our top priority, and their feedback matters most. 
                    Read honest reviews from people who have purchased our products. 
                    We encourage you to leave your own review after your purchase. 
                    Your experiences help us maintain quality standards and continuously improve our products and services.",
                    ImageUrl = "/images/rev.jpg"
                },
                new PageContent
                {
                    Id = 6,
                    PageName = "Terms",
                    Title = "Terms & Conditions",
                    Content = @"By using our website, you agree to comply with our terms and conditions. 
                    All products are subject to availability. Prices and specifications may change without notice. 
                    We reserve the right to refuse service or cancel orders at our discretion. 
                    For detailed terms regarding payment, delivery, and warranties, please read this section carefully.",
                    ImageUrl = "/images/terms.jpg"
                },
                new PageContent
                {
                    Id = 7,
                    PageName = "ReturnExchange",
                    Title = "Return & Exchange Policy",
                    Content = @"Your satisfaction is our priority. You can return or exchange furniture items within 14 days of delivery 
                    if they are in their original condition and packaging. Damaged or custom-made items may have different return terms. 
                    To initiate a return or exchange, contact our support team with your order details.",
                    ImageUrl = "/images/re.jpg"
                },
                new PageContent
                {
                    Id = 8,
                    PageName = "Services",
                    Title = "Our Services",
                    Content = @"We offer a range of services to enhance your furniture shopping experience:
                    - Free delivery on orders above $50
                    - Professional assembly service for all furniture
                    - Customized furniture design consultation
                    - Warranty and after-sales support
                    Our goal is to make your furniture purchase easy, convenient, and stress-free.",
                    ImageUrl = "/images/su.jpg"
                }
            );
            modelBuilder.Entity<NewAddition>().HasData(
    new NewAddition
    {
        Id = 1,
        CategoryId = 9,
        Title = "Table and Chairs",
        ImageUrl = "/images/bt1.jpg"
    },
    new NewAddition
    {
        Id = 2,
        CategoryId = 10,
        Title = "Modern Beds",
        ImageUrl = "/images/bb1.jpg"
    },
    new NewAddition
    {
        Id = 3,
        CategoryId = 11,
        Title = "Kids Wardrobe",
        ImageUrl = "/images/bd1.jpg"
    },
    new NewAddition
    {
        Id = 4,
        CategoryId = 12,
        Title = "Wooden Rocker",
        ImageUrl = "/images/br1.jpg"
    } // ✅ no comma or semicolon here
);

            // <-- Closing the last NewAddition
        }
    }
}
