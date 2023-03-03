using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConstructionAdmin.Data.Migrations
{
    /// <inheritdoc />
    public partial class StockTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "StockId",
                table: "Item",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date_Stock = table.Column<DateTime>(type: "datetime", nullable: false),
                    Quantidade = table.Column<int>(type: "integer", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_StockId",
                table: "Item",
                column: "StockId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Stock_StockId",
                table: "Item",
                column: "StockId",
                principalTable: "Stock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Stock_StockId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropIndex(
                name: "IX_Item_StockId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "StockId",
                table: "Item");
        }
    }
}
