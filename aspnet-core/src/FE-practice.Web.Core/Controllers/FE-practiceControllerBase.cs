using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace FE-practice.Controllers
{
    public abstract class FE-practiceControllerBase: AbpController
    {
        protected FE-practiceControllerBase()
        {
            LocalizationSourceName = FE-practiceConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
