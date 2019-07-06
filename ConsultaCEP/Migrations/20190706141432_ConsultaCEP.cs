using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsultaCEP.Migrations
{
    public partial class ConsultaCEP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "CEPs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cep",
                table: "CEPs");
        }
    }
}
