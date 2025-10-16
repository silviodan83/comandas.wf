using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Comandas.Wf.Migrations
{
    /// <inheritdoc />
    public partial class versao3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoCozinhaItems_PedidoCozinhas_PedidoCozinhaId1",
                table: "PedidoCozinhaItems");

            migrationBuilder.DropIndex(
                name: "IX_PedidoCozinhaItems_PedidoCozinhaId1",
                table: "PedidoCozinhaItems");

            migrationBuilder.DropColumn(
                name: "PedidoCozinhaId1",
                table: "PedidoCozinhaItems");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PedidoCozinhaId1",
                table: "PedidoCozinhaItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCozinhaItems_PedidoCozinhaId1",
                table: "PedidoCozinhaItems",
                column: "PedidoCozinhaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoCozinhaItems_PedidoCozinhas_PedidoCozinhaId1",
                table: "PedidoCozinhaItems",
                column: "PedidoCozinhaId1",
                principalTable: "PedidoCozinhas",
                principalColumn: "Id");
        }
    }
}
