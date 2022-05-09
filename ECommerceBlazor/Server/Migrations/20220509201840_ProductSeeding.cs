using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerceBlazor.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "An 85\" smart tv with all the functionality you could think of, watch your favourite films and shows in 4k!", "https://www.sencor.com/Sencor/media/content/Products/SLE-55US800TCSB-diagonal.jpg", 9.99m, "85 Inch Smart TV UHD (4k)" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Sparkly lava lamp to add a nice effect to any room", "https://geppettostoybox.com/wp-content/uploads/2020/11/Glitter-Lava-Lamp.jpg", 7.99m, "Lava Lamp" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Why not buy a horse to keep you company, very friendly, eats a lot", "https://www.yourhorse.co.uk/wp-content/uploads/image-asset.jpg.webp", 5.00m, "Horse" });
        }

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
        }
    }
}
