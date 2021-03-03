using Microsoft.EntityFrameworkCore.Migrations;

namespace SERVIBARRAS.AccesoDatos.Migrations
{
    public partial class migra4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoGranContribuyenteId",
                table: "Clientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_TipoGranContribuyenteId",
                table: "Clientes",
                column: "TipoGranContribuyenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_TipoGranContribuyente_TipoGranContribuyenteId",
                table: "Clientes",
                column: "TipoGranContribuyenteId",
                principalTable: "TipoGranContribuyente",
                principalColumn: "TipoGranContribuyenteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_TipoGranContribuyente_TipoGranContribuyenteId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_TipoGranContribuyenteId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "TipoGranContribuyenteId",
                table: "Clientes");
        }
    }
}
