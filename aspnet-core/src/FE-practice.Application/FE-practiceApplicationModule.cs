using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FE-practice.Authorization;

namespace FE-practice
{
    [DependsOn(
        typeof(FE-practiceCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FE-practiceApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FE-practiceAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FE-practiceApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
