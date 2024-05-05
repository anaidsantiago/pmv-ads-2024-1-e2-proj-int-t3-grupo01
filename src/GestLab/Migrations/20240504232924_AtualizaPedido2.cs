using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestLab.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaPedido2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Pedido",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Pedido");
        }
    }
}
