using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Nagraj.Controllers
{
    public abstract class NagrajControllerBase: AbpController
    {
        protected NagrajControllerBase()
        {
            LocalizationSourceName = NagrajConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
