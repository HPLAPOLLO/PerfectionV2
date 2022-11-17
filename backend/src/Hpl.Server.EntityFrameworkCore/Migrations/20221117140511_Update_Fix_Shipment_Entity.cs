using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hpl.Server.Migrations
{
    public partial class Update_Fix_Shipment_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Flighgt",
                table: "AppShipments",
                newName: "Flight");

            migrationBuilder.AlterColumn<DateTime>(
                name: "JwAtd",
                table: "AppShipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Flight",
                table: "AppShipments",
                newName: "Flighgt");

            migrationBuilder.AlterColumn<string>(
                name: "JwAtd",
                table: "AppShipments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
