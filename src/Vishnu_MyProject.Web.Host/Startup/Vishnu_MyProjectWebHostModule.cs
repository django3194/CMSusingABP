using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Vishnu_MyProject.Configuration;

namespace Vishnu_MyProject.Web.Host.Startup
{
    [DependsOn(
       typeof(Vishnu_MyProjectWebCoreModule))]
    public class Vishnu_MyProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Vishnu_MyProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Vishnu_MyProjectWebHostModule).GetAssembly());
        }
    }
}
