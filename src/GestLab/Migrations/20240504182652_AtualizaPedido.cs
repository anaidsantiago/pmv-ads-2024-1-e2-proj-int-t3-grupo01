using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestLab.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaPedido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MontadorResponsavelId",
                table: "Pedido",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Pedido",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_MontadorResponsavelId",
                table: "Pedido",
                column: "MontadorResponsavelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Usuarios_MontadorResponsavelId",
                table: "Pedido",
                column: "MontadorResponsavelId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Usuarios_MontadorResponsavelId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_MontadorResponsavelId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "MontadorResponsavelId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Pedido");
        }
    }
}
