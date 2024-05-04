using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestLab.Migrations
{
    /// <inheritdoc />
    public partial class AddArmacaoPedido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArmacaoId",
                table: "Pedido",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ArmacaoId",
                table: "Pedido",
                column: "ArmacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Produto_ArmacaoId",
                table: "Pedido",
                column: "ArmacaoId",
                principalTable: "Produto",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Produto_ArmacaoId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_ArmacaoId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "ArmacaoId",
                table: "Pedido");
        }
    }
}
