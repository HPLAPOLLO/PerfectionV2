﻿using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Hpl.Server.Data;

/* This is used if database provider does't define
 * IServerDbSchemaMigrator implementation.
 */
public class NullServerDbSchemaMigrator : IServerDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
