using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestLab.Migrations
{
    /// <inheritdoc />
    public partial class AddLenteDireitaPedido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Produto_LenteEsquerdaIdId",
                table: "Pedido");

            migrationBuilder.RenameColumn(
                name: "LenteEsquerdaIdId",
                table: "Pedido",
                newName: "LenteEsquerdaId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_LenteEsquerdaIdId",
                table: "Pedido",
                newName: "IX_Pedido_LenteEsquerdaId");

            migrationBuilder.AddColumn<int>(
                name: "LenteDireitaId",
                table: "Pedido",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_LenteDireitaId",
                table: "Pedido",
                column: "LenteDireitaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Produto_LenteDireitaId",
                table: "Pedido",
                column: "LenteDireitaId",
                principalTable: "Produto",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Produto_LenteEsquerdaId",
                table: "Pedido",
                column: "LenteEsquerdaId",
                principalTable: "Produto",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Produto_LenteDireitaId",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Produto_LenteEsquerdaId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_LenteDireitaId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "LenteDireitaId",
                table: "Pedido");

            migrationBuilder.RenameColumn(
                name: "LenteEsquerdaId",
                table: "Pedido",
                newName: "LenteEsquerdaIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedido_LenteEsquerdaId",
                table: "Pedido",
                newName: "IX_Pedido_LenteEsquerdaIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Produto_LenteEsquerdaIdId",
                table: "Pedido",
                column: "LenteEsquerdaIdId",
                principalTable: "Produto",
                principalColumn: "Id");
        }
    }
}
