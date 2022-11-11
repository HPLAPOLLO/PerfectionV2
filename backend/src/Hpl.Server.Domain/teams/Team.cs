using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Hpl.Server.teams
{
    public class Team : AuditedAggregateRoot<Guid>
    {
        public string Description { get; set; }
    }
}
