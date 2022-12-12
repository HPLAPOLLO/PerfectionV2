using Hpl.Server.shipments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Hpl.Server.HouseShipments
{
    public class HouseShipmentAppService : ApplicationService, IHouseShipmentAppService
    {
        private readonly IRepository<HouseShipment, Guid> _houseShipmentRepository;

        public HouseShipmentAppService(IRepository<HouseShipment, Guid> houseShipmentRepository)
        {
            _houseShipmentRepository = houseShipmentRepository;
        }

        public async Task<List<HouseShipmentDto>> GetListAsync()
        {
            var items = await _houseShipmentRepository.GetListAsync();
            return items
                .Select(item => new HouseShipmentDto
                {
                    ContainerNumber = item.ContainerNumber,
                    GrossWeight = item.GrossWeight,
                    GrossWeightUq = item.GrossWeightUq,
                    ConsolidationNumber = item.ConsolidationNumber,
                    AirwaybillNumber = item.AirwaybillNumber,
                    ShipmentType = item.ShipmentType,
                    Origin = item.Origin,
                    Destination = item.Destination,
                    DischargePort = item.DischargePort,
                    LegOrder = item.LegOrder,
                    Etd = item.Etd,
                    Atd = item.Atd,
                    Ata = item.Ata,
                    ShipmentNumber = item.ShipmentNumber,
                    Packs = item.Packs,
                    PackUom = item.PackUom,
                    ActualWeight = item.ActualWeight,
                    UnitOfWeight = item.UnitOfWeight,
                    Shipper = item.Shipper,
                    ConsigneeCode = item.ConsigneeCode,
                    Consignee = item.Consignee,
                    Client = item.Client,
                    ClientCode = item.ClientCode
                }).ToList();
        }
    }
}
