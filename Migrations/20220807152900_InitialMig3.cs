using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineHotelManagementAPI.Migrations
{
    public partial class InitialMig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "roomId",
                table: "Rates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_roomId",
                table: "Rates",
                column: "roomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_Rooms_roomId",
                table: "Rates",
                column: "roomId",
                principalTable: "Rooms",
                principalColumn: "room_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rates_Rooms_roomId",
                table: "Rates");

            migrationBuilder.DropIndex(
                name: "IX_Rates_roomId",
                table: "Rates");

            migrationBuilder.AlterColumn<int>(
                name: "roomId",
                table: "Rates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
