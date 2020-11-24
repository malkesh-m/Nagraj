using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Nagraj.Authorization;

namespace Nagraj
{
    [DependsOn(
        typeof(NagrajCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class NagrajApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<NagrajAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(NagrajApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
