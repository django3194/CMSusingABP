using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Vishnu_MyProject.Authorization;

namespace Vishnu_MyProject
{
    [DependsOn(
        typeof(Vishnu_MyProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Vishnu_MyProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Vishnu_MyProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Vishnu_MyProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
