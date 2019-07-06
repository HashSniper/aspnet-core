using Abp.MultiTenancy;
using MPACORE.PhoneBook.Authorization.Users;

namespace MPACORE.PhoneBook.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
