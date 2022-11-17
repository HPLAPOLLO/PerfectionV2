using Microsoft.EntityFrameworkCore.Migrations;
using System;

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
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipmentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirwayBillNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CarrierCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OhCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegOrder = table.Column<int>(type: "int", nullable: false),
                    Flight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoadPort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Etd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eta = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ata = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AtdCt = table.Column<int>(type: "int", nullable: true),
                    AtaCt = table.Column<int>(type: "int", nullable: true),
                    JwAtd = table.Column<string>(type: "datetime2", nullable: true),
                    DischargePort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsLinked = table.Column<bool>(type: "bit", nullable: true),
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
