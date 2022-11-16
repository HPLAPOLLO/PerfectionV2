using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hpl.Server.Migrations
{
    public partial class Created_Shipment_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppShipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Branch = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipmentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirwayBillNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CarrierCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OhCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegOrder = table.Column<int>(type: "int", nullable: false),
                    Flighgt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoadPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Etd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Eta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ata = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AtdCt = table.Column<int>(type: "int", nullable: false),
                    AtaCt = table.Column<int>(type: "int", nullable: false),
                    JwAtd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargePort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsLinked = table.Column<bool>(type: "bit", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppShipments", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppShipments_AirwayBillNumber",
                table: "AppShipments",
                column: "AirwayBillNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppShipments");
        }
    }
}
