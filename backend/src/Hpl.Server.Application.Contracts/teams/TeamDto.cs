using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Hpl.Server.teams
{
    public class TeamDto : AuditedEntityDto<Guid>
    {
        public string Description { get; set; }
    }
}
