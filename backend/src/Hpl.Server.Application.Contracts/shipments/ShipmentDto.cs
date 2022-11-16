using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Hpl.Server.shipments
{
    public class ShipmentDto : AuditedEntityDto<Guid>
    {
        public string Branch { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string ShipmentId { get; set; }
        public string AirwayBillNumber { get; set; }
        public string CarrierCode { get; set; }
        public string OhCode { get; set; }
        public int LegOrder { get; set; }
        public string Flighgt { get; set; }
        public string LoadPort { get; set; }
        public DateTime Etd { get; set; }
        public DateTime Eta { get; set; }
        public DateTime Ata { get; set; }
        public int AtdCt { get; set; }
        public int AtaCt { get; set; }
        public string JwAtd { get; set; }
        public string DischargePort { get; set; }
        public bool IsLinked { get; set; }
    }
}
