using Hpl.Server.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Hpl.Server;

[DependsOn(
    typeof(ServerEntityFrameworkCoreTestModule)
    )]
public class ServerDomainTestModule : AbpModule
{

}
