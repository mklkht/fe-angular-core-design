using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FE-practice.Configuration;

namespace FE-practice.Web.Host.Startup
{
    [DependsOn(
       typeof(FE-practiceWebCoreModule))]
    public class FE-practiceWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FE-practiceWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FE-practiceWebHostModule).GetAssembly());
        }
    }
}
