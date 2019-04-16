using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Vishnu_MyProject.Controllers
{
    public abstract class Vishnu_MyProjectControllerBase: AbpController
    {
        protected Vishnu_MyProjectControllerBase()
        {
            LocalizationSourceName = Vishnu_MyProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
