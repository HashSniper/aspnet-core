using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MPACORE.PhoneBook.MultiTenancy;

namespace MPACORE.PhoneBook.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
