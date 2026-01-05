using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace website.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoriesAndNewAdditions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Pending",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "NewAdditions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "BannerImageUrl", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 9, "/images/nc1b.jpg", "Functional tables for living and work spaces ", "/images/bt1.jpg", "Table and Chairs" },
                    { 10, "/images/nc2b.jpg", "Comfortable and stylish beds for your bedroom", "/images/bb1.jpg", "Modern Beds" },
                    { 11, "/images/nc3b.jpg", "A spacious and sturdy wardrobe specially designed for kids. Features multiple shelves and hanging space to keep clothes and toys organized, with a fun and colorful design.", "/images/bd1.jpg", "Kids Wardrobe" },
                    { 12, "/images/nc4b.jpg", "A classic wooden rocker designed for comfort and style. Perfect for relaxing in your living room or porch, crafted from high-quality wood for durability.", "/images/br1.jpg", "Wooden Rocker" }
                });

            migrationBuilder.InsertData(
                table: "NewAdditions",
                columns: new[] { "Id", "CategoryId", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, 9, "/images/bt1.jpg", "Table and Chairs" },
                    { 2, 10, "/images/bb1.jpg", "Modern Beds" },
                    { 3, 11, "/images/bd1.jpg", "Kids Wardrobe" },
                    { 4, 12, "/images/br1.jpg", "Wooden Rocker" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewAdditions_CategoryId",
                table: "NewAdditions",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_NewAdditions_Categories_CategoryId",
                table: "NewAdditions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewAdditions_Categories_CategoryId",
                table: "NewAdditions");

            migrationBuilder.DropIndex(
                name: "IX_NewAdditions_CategoryId",
                table: "NewAdditions");

            migrationBuilder.DeleteData(
                table: "NewAdditions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NewAdditions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NewAdditions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NewAdditions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "NewAdditions");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Pending");
        }
    }
}
