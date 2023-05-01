using Abp.Authorization;
using Notification.Authorization.Roles;
using Notification.Authorization.Users;

namespace Notification.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
