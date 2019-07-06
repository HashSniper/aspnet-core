using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using MPACORE.PhoneBook.Authorization.Users;
using MPACORE.PhoneBook.Editions;

namespace MPACORE.PhoneBook.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
