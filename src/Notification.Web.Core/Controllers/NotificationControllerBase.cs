using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Notification.Controllers
{
    public abstract class NotificationControllerBase: AbpController
    {
        protected NotificationControllerBase()
        {
            LocalizationSourceName = NotificationConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
