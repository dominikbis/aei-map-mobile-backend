using Microsoft.EntityFrameworkCore.Migrations;

namespace AEIMapMobile.DAL.Migrations
{
    public partial class AddedPathPoints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExitPointId",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FloorSectorConnections",
                columns: table => new
                {
                    FloorId = table.Column<int>(type: "int", nullable: false),
                    Sector1Id = table.Column<int>(type: "int", nullable: false),
                    Sector2Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloorSectorConnections", x => new { x.FloorId, x.Sector1Id, x.Sector2Id });
                    table.ForeignKey(
                        name: "FK_FloorSectorConnections_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FloorSectorConnections_Sectors_Sector1Id",
                        column: x => x.Sector1Id,
                        principalTable: "Sectors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FloorSectorConnections_Sectors_Sector2Id",
                        column: x => x.Sector2Id,
                        principalTable: "Sectors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PathPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false),
                    IsExitPoint = table.Column<bool>(type: "bit", nullable: false),
                    SectorId = table.Column<int>(type: "int", nullable: false),
                    FloorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PathPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PathPoints_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PathPoints_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NextPathPoints",
                columns: table => new
                {
                    SourcePointId = table.Column<int>(type: "int", nullable: false),
                    NextPointId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NextPathPoints", x => new { x.SourcePointId, x.NextPointId });
                    table.ForeignKey(
                        name: "FK_NextPathPoints_PathPoints_NextPointId",
                        column: x => x.NextPointId,
                        principalTable: "PathPoints",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NextPathPoints_PathPoints_SourcePointId",
                        column: x => x.SourcePointId,
                        principalTable: "PathPoints",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_ExitPointId",
                table: "Rooms",
                column: "ExitPointId",
                unique: true,
                filter: "[ExitPointId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Id",
                table: "Rooms",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Number",
                table: "Rooms",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FloorSectorConnections_FloorId",
                table: "FloorSectorConnections",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_FloorSectorConnections_Sector1Id",
                table: "FloorSectorConnections",
                column: "Sector1Id");

            migrationBuilder.CreateIndex(
                name: "IX_FloorSectorConnections_Sector2Id",
                table: "FloorSectorConnections",
                column: "Sector2Id");

            migrationBuilder.CreateIndex(
                name: "IX_NextPathPoints_NextPointId",
                table: "NextPathPoints",
                column: "NextPointId");

            migrationBuilder.CreateIndex(
                name: "IX_NextPathPoints_SourcePointId",
                table: "NextPathPoints",
                column: "SourcePointId");

            migrationBuilder.CreateIndex(
                name: "IX_PathPoints_FloorId",
                table: "PathPoints",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_PathPoints_SectorId",
                table: "PathPoints",
                column: "SectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_PathPoints_ExitPointId",
                table: "Rooms",
                column: "ExitPointId",
                principalTable: "PathPoints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_PathPoints_ExitPointId",
                table: "Rooms");

            migrationBuilder.DropTable(
                name: "FloorSectorConnections");

            migrationBuilder.DropTable(
                name: "NextPathPoints");

            migrationBuilder.DropTable(
                name: "PathPoints");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_ExitPointId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_Id",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_Number",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "ExitPointId",
                table: "Rooms");
        }
    }
}
