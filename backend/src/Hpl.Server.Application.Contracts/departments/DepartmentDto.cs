using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Hpl.Server.departments
{
    public class DepartmentDto : AuditedEntityDto<Guid>
    {
        public string Description { get; set; }
    }
}
