using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ef_Cache.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Param1 = table.Column<string>(type: "TEXT", nullable: false),
                    Param2 = table.Column<string>(type: "TEXT", nullable: false),
                    Param3 = table.Column<string>(type: "TEXT", nullable: false),
                    Param4 = table.Column<string>(type: "TEXT", nullable: false),
                    Param5 = table.Column<string>(type: "TEXT", nullable: false),
                    Param6 = table.Column<string>(type: "TEXT", nullable: false),
                    Param7 = table.Column<string>(type: "TEXT", nullable: false),
                    Param8 = table.Column<string>(type: "TEXT", nullable: false),
                    Param9 = table.Column<string>(type: "TEXT", nullable: false),
                    Param10 = table.Column<string>(type: "TEXT", nullable: false),
                    Param11 = table.Column<string>(type: "TEXT", nullable: false),
                    Param12 = table.Column<string>(type: "TEXT", nullable: false),
                    Param13 = table.Column<string>(type: "TEXT", nullable: false),
                    Param14 = table.Column<string>(type: "TEXT", nullable: false),
                    Param15 = table.Column<string>(type: "TEXT", nullable: false),
                    Param16 = table.Column<string>(type: "TEXT", nullable: false),
                    Param17 = table.Column<string>(type: "TEXT", nullable: false),
                    Param18 = table.Column<string>(type: "TEXT", nullable: false),
                    Param19 = table.Column<string>(type: "TEXT", nullable: false),
                    Param20 = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Param1 = table.Column<string>(type: "TEXT", nullable: false),
                    Param2 = table.Column<string>(type: "TEXT", nullable: false),
                    Param3 = table.Column<string>(type: "TEXT", nullable: false),
                    Param4 = table.Column<string>(type: "TEXT", nullable: false),
                    Param5 = table.Column<string>(type: "TEXT", nullable: false),
                    Param6 = table.Column<string>(type: "TEXT", nullable: false),
                    Param7 = table.Column<string>(type: "TEXT", nullable: false),
                    Param8 = table.Column<string>(type: "TEXT", nullable: false),
                    Param9 = table.Column<string>(type: "TEXT", nullable: false),
                    Param10 = table.Column<string>(type: "TEXT", nullable: false),
                    Param11 = table.Column<string>(type: "TEXT", nullable: false),
                    Param12 = table.Column<string>(type: "TEXT", nullable: false),
                    Param13 = table.Column<string>(type: "TEXT", nullable: false),
                    Param14 = table.Column<string>(type: "TEXT", nullable: false),
                    Param15 = table.Column<string>(type: "TEXT", nullable: false),
                    Param16 = table.Column<string>(type: "TEXT", nullable: false),
                    Param17 = table.Column<string>(type: "TEXT", nullable: false),
                    Param18 = table.Column<string>(type: "TEXT", nullable: false),
                    Param19 = table.Column<string>(type: "TEXT", nullable: false),
                    Param20 = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Param1 = table.Column<string>(type: "TEXT", nullable: false),
                    Param2 = table.Column<string>(type: "TEXT", nullable: false),
                    Param3 = table.Column<string>(type: "TEXT", nullable: false),
                    Param4 = table.Column<string>(type: "TEXT", nullable: false),
                    Param5 = table.Column<string>(type: "TEXT", nullable: false),
                    Param6 = table.Column<string>(type: "TEXT", nullable: false),
                    Param7 = table.Column<string>(type: "TEXT", nullable: false),
                    Param8 = table.Column<string>(type: "TEXT", nullable: false),
                    Param9 = table.Column<string>(type: "TEXT", nullable: false),
                    Param10 = table.Column<string>(type: "TEXT", nullable: false),
                    Param11 = table.Column<string>(type: "TEXT", nullable: false),
                    Param12 = table.Column<string>(type: "TEXT", nullable: false),
                    Param13 = table.Column<string>(type: "TEXT", nullable: false),
                    Param14 = table.Column<string>(type: "TEXT", nullable: false),
                    Param15 = table.Column<string>(type: "TEXT", nullable: false),
                    Param16 = table.Column<string>(type: "TEXT", nullable: false),
                    Param17 = table.Column<string>(type: "TEXT", nullable: false),
                    Param18 = table.Column<string>(type: "TEXT", nullable: false),
                    Param19 = table.Column<string>(type: "TEXT", nullable: false),
                    Param20 = table.Column<string>(type: "TEXT", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "CategoryStore",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "INTEGER", nullable: false),
                    StoresId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryStore", x => new { x.CategoriesId, x.StoresId });
                    table.ForeignKey(
                        name: "FK_CategoryStore_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryStore_Store_StoresId",
                        column: x => x.StoresId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OptionGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Min = table.Column<int>(type: "INTEGER", nullable: false),
                    Max = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Param1 = table.Column<string>(type: "TEXT", nullable: false),
                    Param2 = table.Column<string>(type: "TEXT", nullable: false),
                    Param3 = table.Column<string>(type: "TEXT", nullable: false),
                    Param4 = table.Column<string>(type: "TEXT", nullable: false),
                    Param5 = table.Column<string>(type: "TEXT", nullable: false),
                    Param6 = table.Column<string>(type: "TEXT", nullable: false),
                    Param7 = table.Column<string>(type: "TEXT", nullable: false),
                    Param8 = table.Column<string>(type: "TEXT", nullable: false),
                    Param9 = table.Column<string>(type: "TEXT", nullable: false),
                    Param10 = table.Column<string>(type: "TEXT", nullable: false),
                    Param11 = table.Column<string>(type: "TEXT", nullable: false),
                    Param12 = table.Column<string>(type: "TEXT", nullable: false),
                    Param13 = table.Column<string>(type: "TEXT", nullable: false),
                    Param14 = table.Column<string>(type: "TEXT", nullable: false),
                    Param15 = table.Column<string>(type: "TEXT", nullable: false),
                    Param16 = table.Column<string>(type: "TEXT", nullable: false),
                    Param17 = table.Column<string>(type: "TEXT", nullable: false),
                    Param18 = table.Column<string>(type: "TEXT", nullable: false),
                    Param19 = table.Column<string>(type: "TEXT", nullable: false),
                    Param20 = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OptionGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OptionGroups_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Option",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    OptionGroupId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Param1 = table.Column<string>(type: "TEXT", nullable: false),
                    Param2 = table.Column<string>(type: "TEXT", nullable: false),
                    Param3 = table.Column<string>(type: "TEXT", nullable: false),
                    Param4 = table.Column<string>(type: "TEXT", nullable: false),
                    Param5 = table.Column<string>(type: "TEXT", nullable: false),
                    Param6 = table.Column<string>(type: "TEXT", nullable: false),
                    Param7 = table.Column<string>(type: "TEXT", nullable: false),
                    Param8 = table.Column<string>(type: "TEXT", nullable: false),
                    Param9 = table.Column<string>(type: "TEXT", nullable: false),
                    Param10 = table.Column<string>(type: "TEXT", nullable: false),
                    Param11 = table.Column<string>(type: "TEXT", nullable: false),
                    Param12 = table.Column<string>(type: "TEXT", nullable: false),
                    Param13 = table.Column<string>(type: "TEXT", nullable: false),
                    Param14 = table.Column<string>(type: "TEXT", nullable: false),
                    Param15 = table.Column<string>(type: "TEXT", nullable: false),
                    Param16 = table.Column<string>(type: "TEXT", nullable: false),
                    Param17 = table.Column<string>(type: "TEXT", nullable: false),
                    Param18 = table.Column<string>(type: "TEXT", nullable: false),
                    Param19 = table.Column<string>(type: "TEXT", nullable: false),
                    Param20 = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Option", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Option_OptionGroups_OptionGroupId",
                        column: x => x.OptionGroupId,
                        principalTable: "OptionGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryStore_StoresId",
                table: "CategoryStore",
                column: "StoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Option_OptionGroupId",
                table: "Option",
                column: "OptionGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_OptionGroups_ProductId",
                table: "OptionGroups",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryStore");

            migrationBuilder.DropTable(
                name: "Option");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "OptionGroups");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
