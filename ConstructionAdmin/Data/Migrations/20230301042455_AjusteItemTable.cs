using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConstructionAdmin.Data.Migrations
{
    /// <inheritdoc />
    public partial class AjusteItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Stock_StockId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_StockId",
                table: "Item");

            migrationBuilder.AlterColumn<Guid>(
                name: "StockId",
                table: "Item",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateIndex(
                name: "IX_Item_StockId",
                table: "Item",
                column: "StockId",
                unique: true,
                filter: "[StockId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Stock_StockId",
                table: "Item",
                column: "StockId",
                principalTable: "Stock",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Stock_StockId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_StockId",
                table: "Item");

            migrationBuilder.AlterColumn<Guid>(
                name: "StockId",
                table: "Item",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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
    }
}
