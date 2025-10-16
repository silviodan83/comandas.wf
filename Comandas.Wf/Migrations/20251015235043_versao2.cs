using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Comandas.Wf.Migrations
{
    /// <inheritdoc />
    public partial class versao2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoCozinhaItems_ComandaItens_ComandaItensId",
                table: "PedidoCozinhaItems");

            migrationBuilder.DropIndex(
                name: "IX_PedidoCozinhaItems_ComandaItensId",
                table: "PedidoCozinhaItems");

            migrationBuilder.DropColumn(
                name: "ComandaItensId",
                table: "PedidoCozinhaItems");

            migrationBuilder.AddColumn<int>(
                name: "PedidoCozinhaId1",
                table: "PedidoCozinhaItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCozinhaItems_ComandaItemId",
                table: "PedidoCozinhaItems",
                column: "ComandaItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCozinhaItems_PedidoCozinhaId1",
                table: "PedidoCozinhaItems",
                column: "PedidoCozinhaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoCozinhaItems_ComandaItens_ComandaItemId",
                table: "PedidoCozinhaItems",
                column: "ComandaItemId",
                principalTable: "ComandaItens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoCozinhaItems_PedidoCozinhas_PedidoCozinhaId1",
                table: "PedidoCozinhaItems",
                column: "PedidoCozinhaId1",
                principalTable: "PedidoCozinhas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoCozinhaItems_ComandaItens_ComandaItemId",
                table: "PedidoCozinhaItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoCozinhaItems_PedidoCozinhas_PedidoCozinhaId1",
                table: "PedidoCozinhaItems");

            migrationBuilder.DropIndex(
                name: "IX_PedidoCozinhaItems_ComandaItemId",
                table: "PedidoCozinhaItems");

            migrationBuilder.DropIndex(
                name: "IX_PedidoCozinhaItems_PedidoCozinhaId1",
                table: "PedidoCozinhaItems");

            migrationBuilder.DropColumn(
                name: "PedidoCozinhaId1",
                table: "PedidoCozinhaItems");

            migrationBuilder.AddColumn<int>(
                name: "ComandaItensId",
                table: "PedidoCozinhaItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCozinhaItems_ComandaItensId",
                table: "PedidoCozinhaItems",
                column: "ComandaItensId");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoCozinhaItems_ComandaItens_ComandaItensId",
                table: "PedidoCozinhaItems",
                column: "ComandaItensId",
                principalTable: "ComandaItens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
