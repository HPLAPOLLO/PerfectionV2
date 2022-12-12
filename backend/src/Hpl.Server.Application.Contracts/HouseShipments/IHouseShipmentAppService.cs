using Hpl.Server.shipments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Hpl.Server.HouseShipments
{
    public interface IHouseShipmentAppService : IApplicationService
    {
        Task<List<HouseShipmentDto>> GetListAsync();
    }
}
