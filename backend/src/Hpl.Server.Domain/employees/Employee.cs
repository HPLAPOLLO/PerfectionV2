using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Hpl.Server.employees
{
    public class Employee : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public float Rate { get; set; }
        public int LunchMins { get; set; }
    }
}
