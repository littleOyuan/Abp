using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Abby.Controllers
{
    public abstract class AbbyControllerBase: AbpController
    {
        protected AbbyControllerBase()
        {
            LocalizationSourceName = AbbyConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
