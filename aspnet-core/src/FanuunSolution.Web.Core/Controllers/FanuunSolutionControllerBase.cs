using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace FanuunSolution.Controllers
{
    public abstract class FanuunSolutionControllerBase: AbpController
    {
        protected FanuunSolutionControllerBase()
        {
            LocalizationSourceName = FanuunSolutionConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
