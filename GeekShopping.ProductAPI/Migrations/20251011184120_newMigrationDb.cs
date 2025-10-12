using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class newMigrationDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 1L, "Roupas", "Camiseta do curso de ASP.NET Core Web API", "https://raw.githubusercontent.com/GeekShopping/GeekShopping/master/Images/Products/camiseta.png", "Camiseta", 79.9m },
                    { 2L, "Acessórios", "Caneca do curso de ASP.NET Core Web API", "https://raw.githubusercontent.com/GeekShopping/GeekShopping/master/Images/Products/caneca.png", "Caneca", 29.9m },
                    { 3L, "Roupas", "Moleton do curso de ASP.NET Core Web API", "https://raw.githubusercontent.com/GeekShopping/GeekShopping/master/Images/Products/moletom.png", "Moleton", 119.9m },
                    { 4L, "Acessórios", "Mousepad do curso de ASP.NET Core Web API", "https://raw.githubusercontent.com/GeekShopping/GeekShopping/master/Images/Products/mousepad.png", "Mousepad", 19.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);
        }
    }
}
