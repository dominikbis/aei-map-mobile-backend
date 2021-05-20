using Microsoft.EntityFrameworkCore.Migrations;

namespace AEIMapMobile.DAL.Migrations
{
    public partial class UpdatedRoomPointsConstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RoomPoints_Order",
                table: "RoomPoints");

            migrationBuilder.CreateIndex(
                name: "IX_RoomPoints_Order_RoomId",
                table: "RoomPoints",
                columns: new[] { "Order", "RoomId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RoomPoints_Order_RoomId",
                table: "RoomPoints");

            migrationBuilder.CreateIndex(
                name: "IX_RoomPoints_Order",
                table: "RoomPoints",
                column: "Order",
                unique: true);
        }
    }
}
