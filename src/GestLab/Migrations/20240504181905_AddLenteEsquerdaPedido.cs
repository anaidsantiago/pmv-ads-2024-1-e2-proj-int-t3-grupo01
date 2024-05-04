using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestLab.Migrations
{
    /// <inheritdoc />
    public partial class AddLenteEsquerdaPedido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LenteEsquerdaIdId",
                table: "Pedido",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_LenteEsquerdaIdId",
                table: "Pedido",
                column: "LenteEsquerdaIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Produto_LenteEsquerdaIdId",
                table: "Pedido",
                column: "LenteEsquerdaIdId",
                principalTable: "Produto",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Produto_LenteEsquerdaIdId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_LenteEsquerdaIdId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "LenteEsquerdaIdId",
                table: "Pedido");
        }
    }
}
