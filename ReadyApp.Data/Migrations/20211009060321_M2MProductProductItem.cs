using Microsoft.EntityFrameworkCore.Migrations;

namespace ReadyApp.Data.Migrations
{
    public partial class M2MProductProductItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductItems_Products_ProductId",
                table: "ProductItems");

            migrationBuilder.DropIndex(
                name: "IX_ProductItems_ProductId",
                table: "ProductItems");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductItems");

            migrationBuilder.CreateTable(
                name: "ProductProductItem",
                columns: table => new
                {
                    ProductItemsProductItemId = table.Column<int>(type: "int", nullable: false),
                    ProductReferancesProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProductItem", x => new { x.ProductItemsProductItemId, x.ProductReferancesProductId });
                    table.ForeignKey(
                        name: "FK_ProductProductItem_ProductItems_ProductItemsProductItemId",
                        column: x => x.ProductItemsProductItemId,
                        principalTable: "ProductItems",
                        principalColumn: "ProductItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProductItem_Products_ProductReferancesProductId",
                        column: x => x.ProductReferancesProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductItem_ProductReferancesProductId",
                table: "ProductProductItem",
                column: "ProductReferancesProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductProductItem");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductItems_ProductId",
                table: "ProductItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductItems_Products_ProductId",
                table: "ProductItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
