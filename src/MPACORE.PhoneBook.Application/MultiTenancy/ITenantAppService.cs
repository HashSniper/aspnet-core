using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MPACORE.PhoneBook.MultiTenancy.Dto;

namespace MPACORE.PhoneBook.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

