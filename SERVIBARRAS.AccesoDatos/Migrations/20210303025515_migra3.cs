using Microsoft.EntityFrameworkCore.Migrations;

namespace SERVIBARRAS.AccesoDatos.Migrations
{
    public partial class migra3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Cupo",
                table: "Clientes",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Plazo",
                table: "Clientes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Plazo",
                table: "Clientes");

            migrationBuilder.AlterColumn<int>(
                name: "Cupo",
                table: "Clientes",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");
        }
    }
}
