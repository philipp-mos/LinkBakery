using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinkBakery.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewBaseValuesToAllTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TrackingLinks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "TrackingLinks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TrackingLinkCalls",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedDate",
                table: "TrackingLinkCalls",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TrackingLinks");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "TrackingLinks");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TrackingLinkCalls");

            migrationBuilder.DropColumn(
                name: "LastModifiedDate",
                table: "TrackingLinkCalls");
        }
    }
}
