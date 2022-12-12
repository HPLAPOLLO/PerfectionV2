using AutoMapper;
using Hpl.Server.departments;
using Hpl.Server.teams;
using Hpl.Server.shipments;
using Hpl.Server.HouseShipments;

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

        CreateMap<Shipment, ShipmentDto>();
        CreateMap<HouseShipment, HouseShipmentDto>();
    }
}
