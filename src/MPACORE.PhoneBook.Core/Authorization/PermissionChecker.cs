using Abp.Authorization;
using MPACORE.PhoneBook.Authorization.Roles;
using MPACORE.PhoneBook.Authorization.Users;

namespace MPACORE.PhoneBook.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
