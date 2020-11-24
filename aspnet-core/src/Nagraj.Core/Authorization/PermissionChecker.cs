using Abp.Authorization;
using Nagraj.Authorization.Roles;
using Nagraj.Authorization.Users;

namespace Nagraj.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
