using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace booking_api.Migrations
{
    public partial class decimo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComprasPassagens");

            migrationBuilder.DropColumn(
                name: "Id_Cliente",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "Id_Passagem",
                table: "Compras");

            migrationBuilder.RenameColumn(
                name: "Data_Passagem",
                table: "Passagens",
                newName: "data_passagem");

            migrationBuilder.AddColumn<int>(
                name: "ComprasId_Compra",
                table: "Passagens",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Passagens_ComprasId_Compra",
                table: "Passagens",
                column: "ComprasId_Compra");

            migrationBuilder.AddForeignKey(
                name: "FK_Passagens_Compras_ComprasId_Compra",
                table: "Passagens",
                column: "ComprasId_Compra",
                principalTable: "Compras",
                principalColumn: "Id_Compra");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passagens_Compras_ComprasId_Compra",
                table: "Passagens");

            migrationBuilder.DropIndex(
                name: "IX_Passagens_ComprasId_Compra",
                table: "Passagens");

            migrationBuilder.DropColumn(
                name: "ComprasId_Compra",
                table: "Passagens");

            migrationBuilder.RenameColumn(
                name: "data_passagem",
                table: "Passagens",
                newName: "Data_Passagem");

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
                name: "IX_ComprasPassagens_PassagensId_Passagem",
                table: "ComprasPassagens",
                column: "PassagensId_Passagem");
        }
    }
}
