using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConstructionAdmin.Data.Migrations
{
    /// <inheritdoc />
    public partial class RequisicaoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "RequisicaoId",
                table: "Item",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Requisicao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data_Requesicao = table.Column<DateTime>(type: "datetime", nullable: false),
                    Estado_Requesicao = table.Column<string>(type: "varchar(100)", nullable: false),
                    Justificacao = table.Column<string>(type: "varchar(500)", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(500)", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requisicao", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_RequisicaoId",
                table: "Item",
                column: "RequisicaoId",
                unique: true,
                filter: "[RequisicaoId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Requisicao_RequisicaoId",
                table: "Item",
                column: "RequisicaoId",
                principalTable: "Requisicao",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Requisicao_RequisicaoId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "Requisicao");

            migrationBuilder.DropIndex(
                name: "IX_Item_RequisicaoId",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "RequisicaoId",
                table: "Item");
        }
    }
}
