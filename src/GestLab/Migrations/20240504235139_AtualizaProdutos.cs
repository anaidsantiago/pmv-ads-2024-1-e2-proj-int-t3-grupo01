using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestLab.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateEntregueCliente",
                table: "Produto",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Utilizado",
                table: "Produto",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ArmacaoEntreguePeloCliente",
                table: "Pedido",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CorLentes",
                table: "Pedido",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdentificacaoArmacao",
                table: "Pedido",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "PossuiLentesEmEstoque",
                table: "Pedido",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEntregueCliente",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Utilizado",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "ArmacaoEntreguePeloCliente",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "CorLentes",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "IdentificacaoArmacao",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "PossuiLentesEmEstoque",
                table: "Pedido");
        }
    }
}
