using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abby.Authorization;

namespace Abby
{
    [DependsOn(
        typeof(AbbyCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbbyApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbbyAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AbbyApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
