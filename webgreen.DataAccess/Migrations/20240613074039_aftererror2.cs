using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webgreen.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class aftererror2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "categoryid",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1,
                column: "categoryid",
                value: 1);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2,
                column: "categoryid",
                value: 3);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3,
                column: "categoryid",
                value: 1);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 4,
                column: "categoryid",
                value: 2);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 5,
                column: "categoryid",
                value: 3);

            migrationBuilder.UpdateData(
                table: "products",
                keyColumn: "Id",
                keyValue: 6,
                column: "categoryid",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_products_categoryid",
                table: "products",
                column: "categoryid");

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_categoryid",
                table: "products",
                column: "categoryid",
                principalTable: "categories",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_categoryid",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_categoryid",
                table: "products");

            migrationBuilder.DropColumn(
                name: "categoryid",
                table: "products");
        }
    }
}
