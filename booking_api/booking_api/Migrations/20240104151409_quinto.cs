using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace booking_api.Migrations
{
    public partial class quinto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Clientes_ClientesId_Cliente",
                table: "Compras");

            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Passagens_PassagensId_Passagem",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_ClientesId_Cliente",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_PassagensId_Passagem",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "ClientesId_Cliente",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "PassagensId_Passagem",
                table: "Compras");

            migrationBuilder.RenameColumn(
                name: "data_passagem",
                table: "Passagens",
                newName: "Data_Passagem");

            migrationBuilder.RenameColumn(
                name: "preco_compra",
                table: "Compras",
                newName: "Preco_Compra");

            migrationBuilder.RenameColumn(
                name: "metodo_pagamento",
                table: "Compras",
                newName: "Metodo_Pagamento");

            migrationBuilder.RenameColumn(
                name: "data_compra",
                table: "Compras",
                newName: "Data_Compra");

            migrationBuilder.RenameColumn(
                name: "idade",
                table: "Clientes",
                newName: "Idade");

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

            migrationBuilder.CreateTable(
                name: "ComprasPassagens",
                columns: table => new
                {
                    ComprasId_Compra = table.Column<int>(type: "int", nullable: false),
                    PassagensId_Passagem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprasPassagens", x => new { x.ComprasId_Compra, x.PassagensId_Passagem });
                    table.ForeignKey(
                        name: "FK_ComprasPassagens_Compras_ComprasId_Compra",
                        column: x => x.ComprasId_Compra,
                        principalTable: "Compras",
                        principalColumn: "Id_Compra",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComprasPassagens_Passagens_PassagensId_Passagem",
                        column: x => x.PassagensId_Passagem,
                        principalTable: "Passagens",
                        principalColumn: "Id_Passagem",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesCompras_ComprasId_Compra",
                table: "ClientesCompras",
                column: "ComprasId_Compra");

            migrationBuilder.CreateIndex(
                name: "IX_ComprasPassagens_PassagensId_Passagem",
                table: "ComprasPassagens",
                column: "PassagensId_Passagem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientesCompras");

            migrationBuilder.DropTable(
                name: "ComprasPassagens");

            migrationBuilder.RenameColumn(
                name: "Data_Passagem",
                table: "Passagens",
                newName: "data_passagem");

            migrationBuilder.RenameColumn(
                name: "Preco_Compra",
                table: "Compras",
                newName: "preco_compra");

            migrationBuilder.RenameColumn(
                name: "Metodo_Pagamento",
                table: "Compras",
                newName: "metodo_pagamento");

            migrationBuilder.RenameColumn(
                name: "Data_Compra",
                table: "Compras",
                newName: "data_compra");

            migrationBuilder.RenameColumn(
                name: "Idade",
                table: "Clientes",
                newName: "idade");

            migrationBuilder.AddColumn<int>(
                name: "ClientesId_Cliente",
                table: "Compras",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PassagensId_Passagem",
                table: "Compras",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ClientesId_Cliente",
                table: "Compras",
                column: "ClientesId_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_PassagensId_Passagem",
                table: "Compras",
                column: "PassagensId_Passagem");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Clientes_ClientesId_Cliente",
                table: "Compras",
                column: "ClientesId_Cliente",
                principalTable: "Clientes",
                principalColumn: "Id_Cliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Passagens_PassagensId_Passagem",
                table: "Compras",
                column: "PassagensId_Passagem",
                principalTable: "Passagens",
                principalColumn: "Id_Passagem");
        }
    }
}
