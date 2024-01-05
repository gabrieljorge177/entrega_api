using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace booking_api.Migrations
{
    public partial class r : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Clientes_clienteId_Cliente",
                table: "Compras");

            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Passagens_passagensId_Passagem",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_clienteId_Cliente",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_passagensId_Passagem",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "clienteId_Cliente",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "passagensId_Passagem",
                table: "Compras");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_Id_Cliente",
                table: "Compras",
                column: "Id_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_Id_Passagem",
                table: "Compras",
                column: "Id_Passagem");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Clientes_Id_Cliente",
                table: "Compras",
                column: "Id_Cliente",
                principalTable: "Clientes",
                principalColumn: "Id_Cliente",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Passagens_Id_Passagem",
                table: "Compras",
                column: "Id_Passagem",
                principalTable: "Passagens",
                principalColumn: "Id_Passagem",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Clientes_Id_Cliente",
                table: "Compras");

            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Passagens_Id_Passagem",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_Id_Cliente",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_Id_Passagem",
                table: "Compras");

            migrationBuilder.AddColumn<int>(
                name: "clienteId_Cliente",
                table: "Compras",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "passagensId_Passagem",
                table: "Compras",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Compras_clienteId_Cliente",
                table: "Compras",
                column: "clienteId_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_passagensId_Passagem",
                table: "Compras",
                column: "passagensId_Passagem");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Clientes_clienteId_Cliente",
                table: "Compras",
                column: "clienteId_Cliente",
                principalTable: "Clientes",
                principalColumn: "Id_Cliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Passagens_passagensId_Passagem",
                table: "Compras",
                column: "passagensId_Passagem",
                principalTable: "Passagens",
                principalColumn: "Id_Passagem");
        }
    }
}
