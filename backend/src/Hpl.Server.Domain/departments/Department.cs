using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Hpl.Server.departments
{
    public class Department : AuditedAggregateRoot<Guid>
    {
        public string Description { get; set; }
    }
}
