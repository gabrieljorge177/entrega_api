using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace booking_api.Migrations
{
    public partial class k : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passagens_Compras_ComprasId_Compra",
                table: "Passagens");

            migrationBuilder.DropTable(
                name: "ClientesCompras");

            migrationBuilder.DropIndex(
                name: "IX_Passagens_ComprasId_Compra",
                table: "Passagens");

            migrationBuilder.DropColumn(
                name: "ComprasId_Compra",
                table: "Passagens");

            migrationBuilder.AddColumn<int>(
                name: "Id_Cliente",
                table: "Compras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Passagem",
                table: "Compras",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Id_Cliente",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "Id_Passagem",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "clienteId_Cliente",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "passagensId_Passagem",
                table: "Compras");

            migrationBuilder.AddColumn<int>(
                name: "ComprasId_Compra",
                table: "Passagens",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ClientesCompras",
                columns: table => new
                {
                    ClientesId_Cliente = table.Column<int>(type: "int", nullable: false),
                    ComprasId_Compra = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesCompras", x => new { x.ClientesId_Cliente, x.ComprasId_Compra });
                    table.ForeignKey(
                        name: "FK_ClientesCompras_Clientes_ClientesId_Cliente",
                        column: x => x.ClientesId_Cliente,
                        principalTable: "Clientes",
                        principalColumn: "Id_Cliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientesCompras_Compras_ComprasId_Compra",
                        column: x => x.ComprasId_Compra,
                        principalTable: "Compras",
                        principalColumn: "Id_Compra",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Passagens_ComprasId_Compra",
                table: "Passagens",
                column: "ComprasId_Compra");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesCompras_ComprasId_Compra",
                table: "ClientesCompras",
                column: "ComprasId_Compra");

            migrationBuilder.AddForeignKey(
                name: "FK_Passagens_Compras_ComprasId_Compra",
                table: "Passagens",
                column: "ComprasId_Compra",
                principalTable: "Compras",
                principalColumn: "Id_Compra");
        }
    }
}
