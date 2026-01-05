using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace website.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Color", "Description", "ImageUrl", "IsTrending", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, 1, "White", "Comfortable bed", "/images/b1.jpg", false, "Bed b1", 35000m, 10 },
                    { 2, 1, "Green", "Stylish bed", "/images/b2.jpg", false, "Bed b2", 40000m, 8 },
                    { 3, 1, "Beige", "Luxury bed", "/images/b3.jpg", false, "Bed b3", 50000m, 5 },
                    { 4, 1, "Brown", "Modern bed", "/images/b4.jpg", false, "Bed b4", 45000m, 7 },
                    { 5, 1, "White", "Classic bed", "/images/b5.jpg", false, "Bed b5", 38000m, 6 },
                    { 6, 1, "Pink", "Cozy bed", "/images/b6.jpg", false, "Bed b6", 42000m, 4 },
                    { 7, 1, "Grey", "Comfort bed", "/images/b7.jpg", false, "Bed b7", 39000m, 8 },
                    { 8, 1, "White", "Elegant bed", "/images/b8.jpg", false, "Bed b8", 46000m, 5 },
                    { 9, 1, "Grey", "Modern bed", "/images/b9.jpg", false, "Bed b9", 47000m, 3 },
                    { 10, 1, "Beige", "Luxury bed", "/images/b10.jpg", false, "Bed b10", 48000m, 4 },
                    { 11, 1, "Pink", "Classic bed", "/images/b11.jpg", false, "Bed b11", 43000m, 6 },
                    { 12, 1, "Beige", "Stylish bed", "/images/b12.jpg", false, "Bed b12", 44000m, 5 },
                    { 13, 2, "Pink", "Soft sofa", "/images/s1.jpg", false, "Sofa s1", 25000m, 7 },
                    { 14, 2, "Blue", "Elegant sofa", "/images/s2.jpg", false, "Sofa s2", 27000m, 4 },
                    { 15, 2, "Green", "Modern sofa", "/images/s3.jpg", false, "Sofa s3", 30000m, 5 },
                    { 16, 2, "Black/White", "Stylish sofa", "/images/s4.jpg", false, "Sofa s4", 32000m, 6 },
                    { 17, 2, "Beige", "Cozy sofa", "/images/s5.jpg", false, "Sofa s5", 29000m, 3 },
                    { 18, 2, "Green", "Comfortable sofa", "/images/s6.jpg", false, "Sofa s6", 31000m, 4 },
                    { 19, 2, "White", "Modern sofa", "/images/s7.jpg", false, "Sofa s7", 28000m, 6 },
                    { 20, 2, "Grey", "Elegant sofa", "/images/s8.jpg", false, "Sofa s8", 30000m, 5 },
                    { 21, 2, "Blue", "Stylish sofa", "/images/s9.jpg", false, "Sofa s9", 33000m, 4 },
                    { 22, 2, "Purple", "Cozy sofa", "/images/s10.jpg", false, "Sofa s10", 34000m, 3 },
                    { 23, 2, "Pink", "Round sofa", "/images/s11.jpg", false, "Sofa s11", 35000m, 2 },
                    { 24, 2, "White", "Comfort sofa", "/images/s12.jpg", false, "Sofa s12", 32000m, 5 },
                    { 25, 2, "Beige", "Luxury sofa", "/images/s13.jpg", false, "Sofa s13", 36000m, 4 },
                    { 26, 3, "White", "Elegant chair", "/images/c1.jpg", false, "Chair c1", 7000m, 10 },
                    { 27, 3, "Brown", "Comfort chair", "/images/c2.jpg", false, "Chair c2", 7500m, 8 },
                    { 28, 3, "Grey", "Stylish chair", "/images/c3.jpg", false, "Chair c3", 8000m, 6 },
                    { 29, 3, "Blue", "Modern chair", "/images/c4.jpg", false, "Chair c4", 8200m, 5 },
                    { 30, 3, "White", "Round chair", "/images/c5.jpg", false, "Chair c5", 8500m, 7 },
                    { 31, 3, "Grey", "Unique chair", "/images/c6.jpg", false, "Chair c6", 8700m, 4 },
                    { 32, 3, "White", "Stylish chair", "/images/c7.jpg", false, "Chair c7", 8800m, 6 },
                    { 33, 3, "Beige", "Comfortable chair", "/images/c8.jpg", false, "Chair c8", 9000m, 5 },
                    { 34, 3, "White", "Modern chair", "/images/c9.jpg", false, "Chair c9", 9100m, 6 },
                    { 35, 3, "Beige", "Round chair", "/images/c10.jpg", false, "Chair c10", 9200m, 4 },
                    { 36, 3, "White", "Stylish chair", "/images/c11.jpg", false, "Chair c11", 9300m, 5 },
                    { 37, 3, "Beige", "Comfort chair", "/images/c12.jpg", false, "Chair c12", 9400m, 3 },
                    { 100, 4, "White", "Modern lamp", "/images/l1.jpg", false, "Lamp l1", 4500m, 10 },
                    { 101, 4, "Black", "Table lamp", "/images/l2.jpg", false, "Lamp l2", 4200m, 8 },
                    { 102, 4, "Gold", "Classic lamp", "/images/l3.jpg", false, "Lamp l3", 5000m, 6 },
                    { 103, 4, "Green", "Elegant lamp", "/images/l4.jpg", false, "Lamp l4", 5500m, 5 },
                    { 104, 4, "Grey", "Modern floor lamp", "/images/l5.jpg", false, "Lamp l5", 6000m, 7 },
                    { 105, 4, "Gold", "Stylish lamp", "/images/l6.jpg", false, "Lamp l6", 5800m, 4 },
                    { 106, 4, "White", "Wall lamp", "/images/l7.jpg", false, "Lamp l7", 6200m, 6 },
                    { 107, 4, "Beige", "Designer lamp", "/images/l8.jpg", false, "Lamp l8", 6500m, 5 },
                    { 108, 4, "Black", "Luxury lamp", "/images/l9.jpg", false, "Lamp l9", 7000m, 4 },
                    { 109, 4, "White", "Premium lamp", "/images/l10.jpg", false, "Lamp l10", 7200m, 3 },
                    { 110, 5, "White", "Decorative mirror", "/images/m1.jpg", false, "Mirror m1", 5800m, 5 },
                    { 111, 5, "Grey", "Modern mirror", "/images/m2.jpg", false, "Mirror m2", 6000m, 6 },
                    { 112, 5, "White", "Artistic mirror", "/images/m3.jpg", false, "Mirror m3", 6500m, 4 },
                    { 113, 5, "Pink", "Round mirror", "/images/m4.jpg", false, "Mirror m4", 6200m, 5 },
                    { 114, 5, "White", "Soft round mirror", "/images/m5.jpg", false, "Mirror m5", 7000m, 3 },
                    { 115, 5, "White", "Tall mirror", "/images/m6.jpg", false, "Mirror m6", 7500m, 4 },
                    { 116, 5, "Black", "Full-length mirror", "/images/m7.jpg", false, "Mirror m7", 7800m, 4 },
                    { 117, 5, "Green", "Luxury mirror", "/images/m8.jpg", false, "Mirror m8", 8200m, 3 },
                    { 118, 6, "Gold", "Decor item", "/images/de1.jpg", false, "Decor de1", 3000m, 10 },
                    { 119, 6, "Beige", "Elegant decor", "/images/de2.jpg", false, "Decor de2", 3500m, 9 },
                    { 120, 6, "Gold", "Modern decor", "/images/de3.jpg", false, "Decor de3", 3800m, 8 },
                    { 121, 6, "Green", "Stylish decor", "/images/de4.jpg", false, "Decor de4", 3600m, 7 },
                    { 122, 6, "Gold", "Premium decor", "/images/de5.jpg", false, "Decor de5", 4000m, 6 },
                    { 123, 6, "Cream", "Vase decor", "/images/de6.jpg", false, "Decor de6", 4200m, 5 },
                    { 124, 6, "Black", "Black decor set", "/images/de7.jpg", false, "Decor de7", 3800m, 4 },
                    { 125, 6, "Brown", "Wood decor", "/images/de8.jpg", false, "Decor de8", 4500m, 6 },
                    { 126, 6, "Silver", "Silver vase", "/images/de9.jpg", false, "Decor de9", 4800m, 5 },
                    { 127, 6, "Gold", "Elegant decor item", "/images/de10.jpg", false, "Decor de10", 5000m, 3 },
                    { 128, 7, "Beige", "Round dining table", "/images/d1.jpg", false, "Dining Table d1", 18000m, 5 },
                    { 129, 7, "Brown", "Wood dining table", "/images/d2.jpg", false, "Dining Table d2", 20000m, 4 },
                    { 130, 7, "White", "Modern dining table", "/images/d3.jpg", false, "Dining Table d3", 21000m, 6 },
                    { 131, 7, "Grey", "Classic dining table", "/images/d4.jpg", false, "Dining Table d4", 22000m, 3 },
                    { 132, 7, "White", "Compact dining table", "/images/d5.jpg", false, "Dining Table d5", 19000m, 6 },
                    { 133, 7, "Black", "Designer dining table", "/images/d6.jpg", false, "Dining Table d6", 24000m, 2 },
                    { 134, 7, "Beige", "Stylish dining table", "/images/d7.jpg", false, "Dining Table d7", 23000m, 4 },
                    { 135, 7, "Brown", "Wood table", "/images/d8.jpg", false, "Dining Table d8", 21000m, 5 },
                    { 136, 7, "Silver", "Glass dining table", "/images/d9.jpg", false, "Dining Table d9", 26000m, 3 },
                    { 137, 7, "White", "Elegant table", "/images/d10.jpg", false, "Dining Table d10", 25000m, 2 },
                    { 138, 7, "Gold", "Luxury dining table", "/images/d11.jpg", false, "Dining Table d11", 30000m, 2 },
                    { 139, 7, "Grey", "Artistic table", "/images/d12.jpg", false, "Dining Table d12", 27000m, 3 },
                    { 140, 8, "White", "Round table", "/images/t1.jpg", false, "Table t1", 9000m, 7 },
                    { 141, 8, "Beige", "Modern table", "/images/t2.jpg", false, "Table t2", 9500m, 6 },
                    { 142, 8, "Brown", "Wood table", "/images/t3.jpg", false, "Table t3", 9800m, 5 },
                    { 143, 8, "White", "Classic table", "/images/t4.jpg", false, "Table t4", 10000m, 4 },
                    { 144, 8, "Grey", "Decor table", "/images/t5.jpg", false, "Table t5", 10200m, 5 },
                    { 145, 8, "White", "Side table", "/images/t6.jpg", false, "Table t6", 11000m, 4 },
                    { 146, 8, "Brown", "Center table", "/images/t7.jpg", false, "Table t7", 12000m, 4 },
                    { 147, 8, "White", "Premium table", "/images/t8.jpg", false, "Table t8", 13000m, 3 },
                    { 148, 8, "Black", "Luxury table", "/images/t9.jpg", false, "Table t9", 15000m, 3 },
                    { 149, 8, "White", "Coffee table", "/images/t10.jpg", false, "Table t10", 14000m, 4 },
                    { 150, 8, "Brown", "Wood coffee table", "/images/t11.jpg", false, "Table t11", 13500m, 5 },
                    { 151, 8, "Gold", "Round center table", "/images/t12.jpg", false, "Table t12", 16000m, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151);
        }
    }
}
