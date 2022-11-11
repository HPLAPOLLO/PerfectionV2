using System.Threading.Tasks;

namespace Hpl.Server.Data;

public interface IServerDbSchemaMigrator
{
    Task MigrateAsync();
}
