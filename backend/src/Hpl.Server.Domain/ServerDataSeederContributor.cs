using Hpl.Server.departments;
using Hpl.Server.shipments;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using static OpenIddict.Abstractions.OpenIddictConstants;

namespace Hpl.Server
{
    public class ServerDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Department, Guid> _departmentRepository;
        private readonly IRepository<Shipment, Guid> _shipmentRepository;

        public ServerDataSeederContributor(
            IRepository<Department, Guid> departmentRepository,
            IRepository<Shipment, Guid> shipmentRepository)
        {
            _departmentRepository = departmentRepository;
            _shipmentRepository = shipmentRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _departmentRepository.GetCountAsync() <= 0)
            {
                await _departmentRepository.InsertAsync(
                    new Department
                    {
                        Description = "Management",
                    },
                    autoSave: true
                );

                await _departmentRepository.InsertAsync(
                    new Department
                    {
                        Description = "Office",
                    },
                    autoSave: true
                );
            }

            if (await _shipmentRepository.GetCountAsync() <= 0)
            {
                await _shipmentRepository.InsertAsync(
                    new Shipment
                    {
                        Branch = "SFO",
                        Origin = "US",
                        Destination = "US",
                        ShipmentId = "CSFO00060454",
                        AirwayBillNumber = "01607227345",
                        CarrierCode = "016",
                        OhCode = "UNIAIR_WW",
                        LegOrder = 1,
                        Flight= "UA1175",
                        LoadPort= "USSFO",
                        Etd = new DateTime(2022, 11, 17, 9, 15, 0),
                        Eta = new DateTime(2022, 11, 17, 12, 47, 0),
                        Ata = new DateTime(),
                        AtdCt = 0,
                        AtaCt = 0,
                        JwAtd = new DateTime(),
                        DischargePort = "USHNL",
                        IsLinked = false
                    },
                    autoSave: true
                );


            }
        }

    }
}
