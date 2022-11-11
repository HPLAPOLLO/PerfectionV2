using Hpl.Server.departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Hpl.Server
{
    public class ServerDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Department, Guid> _departmentRepository;

        public ServerDataSeederContributor(IRepository<Department, Guid> departmentRepository)
        {
            _departmentRepository = departmentRepository;
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
        }

    }
}
