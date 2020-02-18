using Abp.Authorization;
using FE-practice.Authorization.Roles;
using FE-practice.Authorization.Users;

namespace FE-practice.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
