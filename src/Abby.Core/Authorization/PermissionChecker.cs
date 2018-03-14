using Abp.Authorization;
using Abby.Authorization.Roles;
using Abby.Authorization.Users;

namespace Abby.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
