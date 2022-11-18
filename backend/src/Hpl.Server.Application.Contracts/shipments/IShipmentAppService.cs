using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Hpl.Server.shipments
{
    public interface IShipmentAppService : IApplicationService
    {
        Task<List<ShipmentDto>> GetListAsync();
    }
}
