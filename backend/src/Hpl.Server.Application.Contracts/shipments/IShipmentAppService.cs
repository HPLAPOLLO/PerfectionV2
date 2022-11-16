using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Hpl.Server.shipments
{
    public interface IShipmentAppService :
        ICrudAppService<
            ShipmentDto, 
            Guid, 
            PagedAndSortedResultRequestDto>
    {
    }
}
