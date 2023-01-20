using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mango.Services.ProductAPI.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryName", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Appetizer", "Delicious Meal", "https://www.istockphoto.com/photo/group-of-sweet-and-salty-snacks-perfect-for-binge-watching-gm1149135424-310579769", "Samosa", 15.0 },
                    { 2, "Appetizer", "Delicious Meal to the core", "https://www.istockphoto.com/photo/group-of-sweet-and-salty-snacks-perfect-for-binge-watching-gm1149135424-310579769", "Panerr Tikka", 15.24 },
                    { 3, "Dessert", "Delicious Meal", "https://www.istockphoto.com/photo/group-of-sweet-and-salty-snacks-perfect-for-binge-watching-gm1149135424-310579769", "Sweet Pie", 10.99 },
                    { 4, "Appetizer", "Delicious Snacks to the core", "https://www.istockphoto.com/photo/group-of-sweet-and-salty-snacks-perfect-for-binge-watching-gm1149135424-310579769", "Chicken Burger", 15.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
