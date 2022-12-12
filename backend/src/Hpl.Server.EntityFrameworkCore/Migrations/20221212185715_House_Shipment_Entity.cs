using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hpl.Server.Migrations
{
    public partial class House_Shipment_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppHouseShipments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContainerNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrossWeight = table.Column<int>(type: "int", nullable: true),
                    GrossWeightUq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsolidationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirwaybillNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DischargePort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LegOrder = table.Column<int>(type: "int", nullable: true),
                    Etd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Atd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Ata = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShipmentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Packs = table.Column<int>(type: "int", nullable: true),
                    PackUom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActualWeight = table.Column<int>(type: "int", nullable: true),
                    UnitOfWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Shipper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConsigneeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Consignee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppHouseShipments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppHouseShipments");
        }
    }
}
