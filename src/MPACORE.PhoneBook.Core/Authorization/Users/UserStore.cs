using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Linq;
using Abp.Organizations;
using MPACORE.PhoneBook.Authorization.Roles;

namespace MPACORE.PhoneBook.Authorization.Users
{
    public class UserStore : AbpUserStore<Role, User>
    {
        public UserStore(
            IUnitOfWorkManager unitOfWorkManager,
            IRepository<User, long> userRepository,
            IRepository<Role> roleRepository,
            IAsyncQueryableExecuter asyncQueryableExecuter,
            IRepository<UserRole, long> userRoleRepository,
            IRepository<UserLogin, long> userLoginRepository,
            IRepository<UserClaim, long> userClaimRepository,
            IRepository<UserPermissionSetting, long> userPermissionSettingRepository,
            IRepository<UserOrganizationUnit, long> userOrganizationUnitRepository,
            IRepository<OrganizationUnitRole, long> organizationUnitRoleRepository)
            : base(
                unitOfWorkManager,
                userRepository,
                roleRepository,
                asyncQueryableExecuter,
                userRoleRepository,
                userLoginRepository,
                userClaimRepository,
                userPermissionSettingRepository,
                userOrganizationUnitRepository,
                organizationUnitRoleRepository)
        {
        }
    }
}
