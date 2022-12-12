﻿using Hpl.Server.departments;
using Hpl.Server.HouseShipments;
using Hpl.Server.shipments;
using Hpl.Server.teams;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Hpl.Server.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class ServerDbContext :
    AbpDbContext<ServerDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */
    public DbSet<Team> Teams { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Shipment> Shipments { get; set; }
    public DbSet<HouseShipment> HouseShipments { get; set; }

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    public ServerDbContext(DbContextOptions<ServerDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        builder.Entity<Team>(b =>
        {
            b.ToTable(ServerConsts.DbTablePrefix + "Teams",
                ServerConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Description).IsRequired().HasMaxLength(500);

            b.HasIndex(x => x.Description);
        });

        builder.Entity<Department>(b =>
        {
            b.ToTable(ServerConsts.DbTablePrefix + "Departments",
                ServerConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Description).IsRequired().HasMaxLength(500);

            b.HasIndex(x => x.Description);
        });

        builder.Entity<Shipment>(b =>
        {
            b.ToTable(ServerConsts.DbTablePrefix + "Shipments",
                ServerConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props

            b.HasIndex(x => x.AirwayBillNumber);
        });

        builder.Entity<HouseShipment>(b =>
        {
            b.ToTable(ServerConsts.DbTablePrefix + "HouseShipments",
                ServerConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
        });

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(ServerConsts.DbTablePrefix + "YourEntities", ServerConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});
    }
}
