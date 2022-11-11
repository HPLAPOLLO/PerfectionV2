using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Hpl.Server.departments
{
    public class DepartmentAppService :
        CrudAppService<
            Department, //The Department entity
            DepartmentDto, //Used to show Department
            Guid, //Primary key of the Department entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateDepartmentDto>, //Used to create/update a Department
        IDepartmentAppService //implement the IDepartmentAppService
    {
        public DepartmentAppService(IRepository<Department, Guid> repository)
            : base(repository)
        {

        }
    }
}
