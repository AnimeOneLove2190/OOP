using Microsoft.EntityFrameworkCore.Migrations;

namespace EFVaiaa.Migrations.CinemaEF
{
    public partial class updateTicketTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Tickets",
                newName: "DateOfSale");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfSale",
                table: "Tickets",
                newName: "DateTime");
        }
    }
}
