using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using static OpenIddict.Abstractions.OpenIddictConstants;

namespace Hpl.Server.shipments
{
    public class ShipmentAppService : ApplicationService, IShipmentAppService
    {
        private readonly IRepository<Shipment, Guid> _shipmentRepository;

        public ShipmentAppService(IRepository<Shipment, Guid> shipmentRepository)
        {
            _shipmentRepository = shipmentRepository;
        }

        public async Task<List<ShipmentDto>> GetListAsync()
        {
            var items = await _shipmentRepository.GetListAsync();
            return items
                .Select(item => new ShipmentDto
                {
                    Branch = item.Branch,
                    Origin = item.Origin,
                    Destination = item.Destination,
                    ShipmentId = item.ShipmentId,
                    AirwayBillNumber = item.AirwayBillNumber,
                    CarrierCode = item.CarrierCode,
                    OhCode = item.OhCode,
                    LegOrder = item.LegOrder,
                    Flight = item.Flight,
                    LoadPort = item.LoadPort,
                    Etd = item.Etd,
                    Eta = item.Eta,
                    Ata = item.Ata,
                    AtdCt = item.AtdCt,
                    AtaCt = item.AtaCt,
                    JwAtd = item.JwAtd,
                    DischargePort = item.DischargePort,
                    IsLinked = item.IsLinked
                }).ToList();
        }
    }
}
