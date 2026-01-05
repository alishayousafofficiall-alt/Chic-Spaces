using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace website.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "BannerImageUrl", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "/images/bed1.jpg", "Comfortable and stylish beds for your bedroom", "/images/b1.jpg", "Beds" },
                    { 2, "/images/Sofas.jpg", "Comfortable and stylish beds for your bedroom", "/images/s1.jpg", "Sofas" },
                    { 3, "/images/ch.jpg", "Elegant chairs for dining and living spaces", "/images/c1.jpg", "Chairs" },
                    { 4, "/images/lamp.jpg", "Stylish lighting to brighten your home", "/images/l1.jpg", "Lamps" },
                    { 5, "/images/mi.jpg", "Decorative mirrors for every room", "/images/m1.jpg", "Mirrors" },
                    { 6, "/images/di.jpg", "Beautiful decor items to enhance your space", "/images/de1.jpg", "Decor Items" },
                    { 7, "/images/dining.jpg", "Elegant dining tables for family meals", "/images/d1.jpg", "Dining Tables" },
                    { 8, "/images/tab.jpg", "Functional tables for living and work spaces", "/images/t1.jpg", "Tables" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
