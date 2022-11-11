using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Hpl.Server.teams
{
    public class TeamAppService  :
         CrudAppService<
            Team, //The Team entity
            TeamDto, //Used to show Team
            Guid, //Primary key of the Team entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateTeamDto>, //Used to create/update a Department
        ITeamAppService //implement the ITeamAppService
    {
        public TeamAppService(IRepository<Team, Guid> repository)
             : base(repository)
        {

        }
    }
}
