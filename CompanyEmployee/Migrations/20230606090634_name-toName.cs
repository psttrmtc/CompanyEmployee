using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployee.Migrations
{
    public partial class nametoName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Companies",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Companies",
                newName: "name");
        }
    }
}
