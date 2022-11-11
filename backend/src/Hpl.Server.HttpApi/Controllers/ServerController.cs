using Hpl.Server.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Hpl.Server.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ServerController : AbpControllerBase
{
    protected ServerController()
    {
        LocalizationResource = typeof(ServerResource);
    }
}
