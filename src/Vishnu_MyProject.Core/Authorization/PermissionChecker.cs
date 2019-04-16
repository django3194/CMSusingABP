using Abp.Authorization;
using Vishnu_MyProject.Authorization.Roles;
using Vishnu_MyProject.Authorization.Users;

namespace Vishnu_MyProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
