using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Vishnu_MyProject.Configuration;
using Vishnu_MyProject.EntityFrameworkCore;
using Vishnu_MyProject.Migrator.DependencyInjection;

namespace Vishnu_MyProject.Migrator
{
    [DependsOn(typeof(Vishnu_MyProjectEntityFrameworkModule))]
    public class Vishnu_MyProjectMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public Vishnu_MyProjectMigratorModule(Vishnu_MyProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(Vishnu_MyProjectMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                Vishnu_MyProjectConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Vishnu_MyProjectMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
