using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Hpl.Server.HouseShipments
{
    public class HouseShipment : AuditedAggregateRoot<Guid>
    {
        public string? ContainerNumber { get; set; }
        public int? GrossWeight { get; set; }
        public string? GrossWeightUq { get; set; }
        public string? ConsolidationNumber { get; set; }
        public string? AirwaybillNumber { get; set; }
        public string? ShipmentType { get; set; }
        public string? Origin { get; set; }
        public string? Destination { get; set; }
        public string? DischargePort { get; set; }
        public int? LegOrder { get; set; }
        public DateTime? Etd { get; set; }
        public DateTime? Atd { get; set; }
        public DateTime? Ata { get; set; }
        public string? ShipmentNumber { get; set; }
        public int? Packs { get; set; }
        public string? PackUom { get; set; }
        public int? ActualWeight { get; set; }
        public string? UnitOfWeight { get; set; }
        public string? Shipper { get; set; }
        public string? ConsigneeCode { get; set; }
        public string? Consignee { get; set; }
        public string? Client { get; set; }
        public string? ClientCode { get; set; }
    }
}
