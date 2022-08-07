using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineHotelManagementAPI.Migrations
{
    public partial class InitialMig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rates_Rooms_roomId",
                table: "Rates");

            migrationBuilder.RenameColumn(
                name: "roomId",
                table: "Rates",
                newName: "room_id");

            migrationBuilder.RenameIndex(
                name: "IX_Rates_roomId",
                table: "Rates",
                newName: "IX_Rates_room_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_Rooms_room_id",
                table: "Rates",
                column: "room_id",
                principalTable: "Rooms",
                principalColumn: "room_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rates_Rooms_room_id",
                table: "Rates");

            migrationBuilder.RenameColumn(
                name: "room_id",
                table: "Rates",
                newName: "roomId");

            migrationBuilder.RenameIndex(
                name: "IX_Rates_room_id",
                table: "Rates",
                newName: "IX_Rates_roomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_Rooms_roomId",
                table: "Rates",
                column: "roomId",
                principalTable: "Rooms",
                principalColumn: "room_id");
        }
    }
}
