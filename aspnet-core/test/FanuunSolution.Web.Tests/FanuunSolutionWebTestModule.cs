using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FanuunSolution.EntityFrameworkCore;
using FanuunSolution.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace FanuunSolution.Web.Tests
{
    [DependsOn(
        typeof(FanuunSolutionWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class FanuunSolutionWebTestModule : AbpModule
    {
        public FanuunSolutionWebTestModule(FanuunSolutionEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FanuunSolutionWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(FanuunSolutionWebMvcModule).Assembly);
        }
    }
}