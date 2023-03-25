using Abp.Authorization;
using FanuunSolution.Authorization.Roles;
using FanuunSolution.Authorization.Users;

namespace FanuunSolution.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
