using Hpl.Server.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Hpl.Server.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ServerEntityFrameworkCoreModule),
    typeof(ServerApplicationContractsModule)
    )]
public class ServerDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
