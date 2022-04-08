using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinkBakery.Core.Migrations
{
    public partial class AddQueryParameterFlagsToTrackingLinksTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "RedirectWithQueryParameter",
                table: "TrackingLinks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "QueryParameter",
                table: "TrackingLinkCalls",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RedirectWithQueryParameter",
                table: "TrackingLinks");

            migrationBuilder.DropColumn(
                name: "QueryParameter",
                table: "TrackingLinkCalls");
        }
    }
}
