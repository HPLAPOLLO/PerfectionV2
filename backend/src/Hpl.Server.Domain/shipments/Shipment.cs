using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Hpl.Server.shipments
{
    public class Shipment : AuditedAggregateRoot<Guid>
    {
        public string Branch { get; set; }
        public string Origin { get; set; }
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
