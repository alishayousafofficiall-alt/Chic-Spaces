using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace website.Migrations
{
    /// <inheritdoc />
    public partial class SeedBannersSlidersPages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "Id", "ImageUrl", "Page" },
                values: new object[,]
                {
                    { 1, "/images/ba1.jpg", "Admin" },
                    { 4, "/images/ba1.jpg", "User" }
                });

            migrationBuilder.InsertData(
                table: "PageContents",
                columns: new[] { "Id", "Content", "ImageUrl", "PageName", "Title" },
                values: new object[,]
                {
                    { 1, "Welcome to our website! We are a dedicated team committed to providing the highest quality products to our customers. \r\n                    Our mission is to combine excellent service with affordable prices, ensuring every customer has a \r\n                    seamless shopping experience. We believe in transparency, trust, and building long-lasting relationships \r\n                    with our clients. From product selection to delivery, we ensure every step meets the highest standards.", "/images/ab1.jpg", "About", "About us" },
                    { 2, "Have questions or need assistance? Our customer support team is here to help. \r\n                    You can reach us via email at support@example.com or call us at (123) 456-7890. \r\n                    Our office hours are Monday to Friday, 9 AM to 6 PM. We also provide live chat support for \r\n                    instant assistance during business hours. Your feedback is important to us and helps us improve.", "/images/co.jpg", "Contact", "Contact Us" },
                    { 3, "We value your privacy and are committed to protecting your personal information. \r\n                    Any data you provide is securely stored and used only for order processing and customer support. \r\n                    We do not sell, trade, or share your information with third parties without your consent. \r\n                    Our website uses cookies to enhance your browsing experience, and you can manage your preferences at any time.", "/images/pi.jpg", "Privacy Policy", "Privacy Policy" },
                    { 4, "We provide fast and reliable delivery services across the country. Orders are typically processed within \r\n                    24 hours and delivered within 3-7 business days, depending on your location. Free shipping is available \r\n                    for orders over $50. You can track your order at any time using our tracking system. \r\n                    In case of delays, our support team will notify you promptly.", "/images/de.jpg", "Delivery", "Delivery Information" },
                    { 5, "Our customers are our top priority, and their feedback matters most. \r\n                    Read honest reviews from people who have purchased our products. \r\n                    We encourage you to leave your own review after your purchase. \r\n                    Your experiences help us maintain quality standards and continuously improve our products and services.", "/images/rev.jpg", "Reviews", "Customer Reviews" },
                    { 6, "By using our website, you agree to comply with our terms and conditions. \r\n                    All products are subject to availability. Prices and specifications may change without notice. \r\n                    We reserve the right to refuse service or cancel orders at our discretion. \r\n                    For detailed terms regarding payment, delivery, and warranties, please read this section carefully.", "/images/terms.jpg", "Terms", "Terms & Conditions" },
                    { 7, "Your satisfaction is our priority. You can return or exchange furniture items within 14 days of delivery \r\n                    if they are in their original condition and packaging. Damaged or custom-made items may have different return terms. \r\n                    To initiate a return or exchange, contact our support team with your order details.", "/images/re.jpg", "ReturnExchange", "Return & Exchange Policy" },
                    { 8, "We offer a range of services to enhance your furniture shopping experience:\r\n                    - Free delivery on orders above $50\r\n                    - Professional assembly service for all furniture\r\n                    - Customized furniture design consultation\r\n                    - Warranty and after-sales support\r\n                    Our goal is to make your furniture purchase easy, convenient, and stress-free.", "/images/su.jpg", "Services", "Our Services" }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "/images/slider1.jpg" },
                    { 2, "/images/slider2.jpg" },
                    { 3, "/images/slider3.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Banners",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PageContents",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
