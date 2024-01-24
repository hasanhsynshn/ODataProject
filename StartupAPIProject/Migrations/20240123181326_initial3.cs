using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StartupAPIProject.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PriceUnit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Image", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 23, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(1981), null, "Apple, IOS", "test.jpg", "Apple", null },
                    { 2, new DateTime(2024, 1, 22, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(2012), null, "Samsung, OneUI", "test.jpg", "Samsung", null },
                    { 3, new DateTime(2024, 1, 21, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(2016), null, "Redmi", "test.jpg", "Xiaomi", null },
                    { 4, new DateTime(2024, 1, 20, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(2017), null, "Android", "test.jpg", "Oppo", null },
                    { 5, new DateTime(2024, 1, 19, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(2018), null, "Android", "test.jpg", "Realme", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CategoryName", "CreatedDate", "DeletedDate", "Description", "Image", "Name", "Price", "PriceUnit", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, "Apple", new DateTime(2024, 1, 23, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(2114), null, "Apple, IOS", "product.jpeg", "Apple", 0m, 0m, 0, null },
                    { 2, 2, "Samsung", new DateTime(2024, 1, 22, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(2116), null, "Samsung, OneUI", "product.jpeg", "Samsung", 0m, 0m, 0, null },
                    { 3, 3, "Xiaomi", new DateTime(2024, 1, 21, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(2118), null, "Redmi", "product.jpeg", "Xiaomi", 0m, 0m, 0, null },
                    { 4, 4, "Oppo", new DateTime(2024, 1, 20, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(2119), null, "Android", "product.jpeg", "Oppo", 0m, 0m, 0, null },
                    { 5, 5, "Realme", new DateTime(2024, 1, 19, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(2120), null, "Android", "product.jpeg", "Realme", 0m, 0m, 0, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
