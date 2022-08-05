using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineHotelManagementAPI.Migrations
{
    public partial class FinalMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Payments");
        }
    }
}
