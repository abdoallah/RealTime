using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Notification.Authorization;

namespace Notification
{
    [DependsOn(
        typeof(NotificationCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class NotificationApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<NotificationAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(NotificationApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
