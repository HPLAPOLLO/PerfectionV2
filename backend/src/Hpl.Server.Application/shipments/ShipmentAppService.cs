using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Hpl.Server.shipments
{
    public class ShipmentAppService :
        CrudAppService<
            Shipment, 
            ShipmentDto,
            Guid,
            PagedAndSortedResultRequestDto>, 
        IShipmentAppService 
    {
        public ShipmentAppService(IRepository<Shipment, Guid> repository)
            : base(repository)
        {

        }
    }
}
