using Microsoft.EntityFrameworkCore.Migrations;

namespace SERVIBARRAS.AccesoDatos.Migrations
{
    public partial class migra2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cupo",
                table: "Clientes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cupo",
                table: "Clientes");
        }
    }
}
