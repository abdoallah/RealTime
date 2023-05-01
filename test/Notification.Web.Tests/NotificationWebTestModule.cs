using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Notification.EntityFrameworkCore;
using Notification.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Notification.Web.Tests
{
    [DependsOn(
        typeof(NotificationWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class NotificationWebTestModule : AbpModule
    {
        public NotificationWebTestModule(NotificationEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NotificationWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(NotificationWebMvcModule).Assembly);
        }
    }
}