using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Hpl.Server.teams
{
    public interface ITeamAppService :
        ICrudAppService< //Defines CRUD methods
            TeamDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateTeamDto> //Used to create/update a book
    {

    }
}
