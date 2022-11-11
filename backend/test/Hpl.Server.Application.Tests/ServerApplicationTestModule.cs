using Volo.Abp.Modularity;

namespace Hpl.Server;

[DependsOn(
    typeof(ServerApplicationModule),
    typeof(ServerDomainTestModule)
    )]
public class ServerApplicationTestModule : AbpModule
{

}
