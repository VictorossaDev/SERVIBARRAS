using Microsoft.EntityFrameworkCore.Migrations;

namespace SERVIBARRAS.AccesoDatos.Migrations
{
    public partial class migra6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "MarcaDeExtranjero",
                table: "Clientes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MarcaDeExtranjero",
                table: "Clientes");
        }
    }
}
