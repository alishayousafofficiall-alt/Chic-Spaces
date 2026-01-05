using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace website.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductsForNewAddition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BannerImageUrl",
                table: "NewAdditions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "NewAdditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "BannerImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "NewAdditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "BannerImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "NewAdditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "BannerImageUrl",
                value: null);

            migrationBuilder.UpdateData(
                table: "NewAdditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "BannerImageUrl",
                value: null);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Color", "Description", "ImageUrl", "IsTrending", "Name", "NewAdditionId", "Price", "Stock" },
                values: new object[,]
                {
                    { 153, 3, "White", "Round chair", "/images/c5.jpg", true, "Chair c5", null, 8500m, 7 },
                    { 154, 7, "White", "Elegant table", "/images/d10.jpg", true, "Dining Table d10", null, 25000m, 2 },
                    { 155, 6, "Cream", "Vase decor", "/images/de6.jpg", true, "Decor de6", null, 4200m, 5 },
                    { 156, 5, "White", "Decorative mirror", "/images/m1.jpg", true, "Mirror m1", null, 5800m, 5 },
                    { 157, 8, "Black", "Luxury table", "/images/t9.jpg", true, "Table t9", null, 15000m, 3 },
                    { 158, 2, "Beige", "Luxury sofa", "/images/s13.jpg", true, "Sofa s13", null, 36000m, 4 },
                    { 159, 4, "Green", "Elegant lamp", "/images/l4.jpg", true, "Lamp l4", null, 5500m, 5 },
                    { 160, 1, "Grey", "Modern bed", "/images/b9.jpg", true, "Bed b9", null, 47000m, 3 },
                    { 161, 7, "Gold", "Luxury dining table", "/images/d11.jpg", true, "Dining Table d11", null, 30000m, 2 },
                    { 162, 6, "Gold", "Elegant decor item", "/images/de10.jpg", true, "Decor de10", null, 5000m, 3 },
                    { 163, 8, "Gold", "Round center table", "/images/t12.jpg", true, "Table t12", null, 16000m, 2 },
                    { 171, 9, "Brown", "Elegant table set", "/images/bt1.jpg", false, "Table Set 2", 1, 35000m, 5 },
                    { 172, 9, "Brown", "Stylish table set", "/images/bt2.jpg", false, "Table Set 2", 1, 38000m, 5 },
                    { 173, 9, "Brown", "Elegant table set", "/images/bt3.jpg", false, "Table Set 3", 1, 35000m, 5 },
                    { 174, 9, "Brown", "Stylish table set", "/images/bt4.jpg", false, "Table Set 4", 1, 38000m, 5 },
                    { 175, 9, "Brown", "Elegant table set", "/images/bt5.jpg", false, "Table Set 5", 1, 35000m, 5 },
                    { 176, 9, "Brown", "Elegant table set", "/images/bt6.jpg", false, "Table Set 6", 1, 35000m, 5 },
                    { 177, 9, "Brown", "Elegant table set", "/images/bt7.jpg", false, "Table Set 7", 1, 35000m, 5 },
                    { 178, 9, "Brown", "Stylish table set", "/images/bt8.jpg", false, "Table Set 8", 1, 38000m, 5 },
                    { 179, 9, "Brown", "Elegant table set", "/images/bt9.jpg", false, "Table Set 9", 1, 35000m, 5 },
                    { 180, 9, "Brown", "Stylish table set", "/images/bt10.jpg", false, "Table Set 10", 1, 38000m, 5 },
                    { 181, 10, "Brown", "Comfortable modern bed", "/images/bb1.jpg", false, "Modern Bed 1", 2, 40000m, 3 },
                    { 182, 10, "Brown", "Luxury modern bed", "/images/bb3.jpg", false, "Modern Bed 2", 2, 45000m, 3 },
                    { 183, 10, "Brown", "Comfortable modern bed", "/images/bb4.jpg", false, "Modern Bed 3", 2, 40000m, 3 },
                    { 184, 10, "Brown", "Luxury modern bed", "/images/bb5.jpg", false, "Modern Bed 4", 2, 45000m, 3 },
                    { 185, 10, "Brown", "Comfortable modern bed", "/images/bb6.jpg", false, "Modern Bed 5", 2, 40000m, 3 },
                    { 186, 10, "Brown", "Luxury modern bed", "/images/bb7.jpg", false, "Modern Bed 6", 2, 45000m, 3 },
                    { 187, 10, "Brown", "Comfortable modern bed", "/images/bb8.jpg", false, "Modern Bed 7", 2, 40000m, 3 },
                    { 188, 10, "Brown", "Luxury modern bed", "/images/bb9.jpg", false, "Modern Bed 8", 2, 45000m, 3 },
                    { 189, 10, "Brown", "Comfortable modern bed", "/images/bb10.jpg", false, "Modern Bed 9", 2, 40000m, 3 },
                    { 190, 10, "Brown", "Luxury modern bed", "/images/bb11.jpg", false, "Modern Bed 10", 2, 45000m, 3 },
                    { 191, 11, "Brown", "Colorful kids wardrobe", "/images/bd1.jpg", false, "Kids Wardrobe 1", 3, 12000m, 1 },
                    { 192, 11, "Brown", "Spacious kids wardrobe", "/images/bd2.jpg", false, "Kids Wardrobe 2", 3, 15000m, 1 },
                    { 193, 11, "Brown", "Colorful kids wardrobe", "/images/bd3.jpg", false, "Kids Wardrobe 3", 3, 12000m, 1 },
                    { 194, 11, "Brown", "Spacious kids wardrobe", "/images/bd4.jpg", false, "Kids Wardrobe 4", 3, 15000m, 1 },
                    { 195, 11, "Brown", "Colorful kids wardrobe", "/images/bd5.jpg", false, "Kids Wardrobe 5", 3, 12000m, 1 },
                    { 196, 11, "Brown", "Spacious kids wardrobe", "/images/bd6.jpg", false, "Kids Wardrobe 6", 3, 15000m, 1 },
                    { 197, 11, "Brown", "Colorful kids wardrobe", "/images/bb7.jpg", false, "Kids Wardrobe 7", 3, 12000m, 1 },
                    { 198, 11, "Brown", "Spacious kids wardrobe", "/images/bd8.jpg", false, "Kids Wardrobe 8", 3, 15000m, 1 },
                    { 199, 11, "Brown", "Colorful kids wardrobe", "/images/bd9.jpg", false, "Kids Wardrobe 9", 3, 12000m, 1 },
                    { 200, 11, "Brown", "Spacious kids wardrobe", "/images/bd10.jpg", false, "Kids Wardrobe 10", 3, 15000m, 1 },
                    { 201, 12, "Brown", "Classic wooden rocker", "/images/br1.jpg", false, "Wooden Rocker 1", 4, 15000m, 3 },
                    { 202, 12, "Brown", "Comfortable wooden rocker", "/images/br2.jpg", false, "Wooden Rocker 2", 4, 18000m, 3 },
                    { 203, 12, "Brown", "Classic wooden rocker", "/images/br3.jpg", false, "Wooden Rocker 3", 4, 15000m, 3 },
                    { 204, 12, "Brown", "Comfortable wooden rocker", "/images/br4.jpg", false, "Wooden Rocker 4", 4, 18000m, 3 },
                    { 205, 12, "Brown", "Classic wooden rocker", "/images/br5.jpg", false, "Wooden Rocker 5", 4, 15000m, 3 },
                    { 206, 12, "Brown", "Comfortable wooden rocker", "/images/br6.jpg", false, "Wooden Rocker 6", 4, 18000m, 3 },
                    { 207, 12, "Brown", "Classic wooden rocker", "/images/br7.jpg", false, "Wooden Rocker 7", 4, 15000m, 3 },
                    { 208, 12, "Brown", "Comfortable wooden rocker", "/images/br8.jpg", false, "Wooden Rocker 8", 4, 18000m, 3 },
                    { 209, 12, "Brown", "Classic wooden rocker", "/images/br19.jpg", false, "Wooden Rocker 9", 4, 15000m, 3 },
                    { 210, 12, "Brown", "Comfortable wooden rocker", "/images/br10.jpg", false, "Wooden Rocker 10", 4, 18000m, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DropColumn(
                name: "BannerImageUrl",
                table: "NewAdditions");
        }
    }
}
