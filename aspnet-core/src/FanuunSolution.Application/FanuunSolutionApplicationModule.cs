using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FanuunSolution.Authorization;

namespace FanuunSolution
{
    [DependsOn(
        typeof(FanuunSolutionCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class FanuunSolutionApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<FanuunSolutionAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(FanuunSolutionApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
