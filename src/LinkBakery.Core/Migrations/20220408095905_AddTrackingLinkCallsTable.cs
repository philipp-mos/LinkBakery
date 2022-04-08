using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinkBakery.Core.Migrations
{
    public partial class AddTrackingLinkCallsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrackingLinkCalls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrackingLinkId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackingLinkCalls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrackingLinkCalls_TrackingLinks_TrackingLinkId",
                        column: x => x.TrackingLinkId,
                        principalTable: "TrackingLinks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrackingLinkCalls_TrackingLinkId",
                table: "TrackingLinkCalls",
                column: "TrackingLinkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrackingLinkCalls");
        }
    }
}
