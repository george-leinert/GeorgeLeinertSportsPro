﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCHOT2.Migrations
{
    /// <inheritdoc />
    public partial class Migration01Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescShort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescLong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductQty = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "ProductDescLong", "ProductDescShort", "ProductImage", "ProductName", "ProductPrice", "ProductQty" },
                values: new object[,]
                {
                    { 1, 4, "", "", "", "AeroFlo ATB Wheels", 189m, 40 },
                    { 2, 1, "", "", "", "Clear Shade 85-T Glasses", 45m, 14 },
                    { 3, 4, "", "", "", "Cosmic Elite Road Warrior Wheels", 165m, 22 },
                    { 4, 1, "", "", "", "Cycle-Doc Pro Repair Stand", 166m, 12 },
                    { 5, 1, "", "", "", "Dog Ear Aero-Flow Floor Pump", 5m, 25 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
