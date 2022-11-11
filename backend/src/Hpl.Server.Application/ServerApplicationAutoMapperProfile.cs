using AutoMapper;
using Hpl.Server.departments;
using Hpl.Server.teams;

namespace Hpl.Server;

public class ServerApplicationAutoMapperProfile : Profile
{
    public ServerApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Department, DepartmentDto>();
        CreateMap<CreateUpdateDepartmentDto, Department>();
        CreateMap<Team, TeamDto>();
        CreateMap<CreateUpdateTeamDto, Team>();
    }
}
