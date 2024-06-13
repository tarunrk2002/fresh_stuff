using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webgreen.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changeddatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_categoryid",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "categoryid",
                table: "products",
                newName: "Categoryid");

            migrationBuilder.RenameIndex(
                name: "IX_products_categoryid",
                table: "products",
                newName: "IX_products_Categoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_Categoryid",
                table: "products",
                column: "Categoryid",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_Categoryid",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "Categoryid",
                table: "products",
                newName: "categoryid");

            migrationBuilder.RenameIndex(
                name: "IX_products_Categoryid",
                table: "products",
                newName: "IX_products_categoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_categoryid",
                table: "products",
                column: "categoryid",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
