using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FanuunSolution.Configuration;

namespace FanuunSolution.Web.Host.Startup
{
    [DependsOn(
       typeof(FanuunSolutionWebCoreModule))]
    public class FanuunSolutionWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public FanuunSolutionWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FanuunSolutionWebHostModule).GetAssembly());
        }
    }
}
