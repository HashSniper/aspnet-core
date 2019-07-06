using Abp.Application.Services.Dto;

namespace MPACORE.PhoneBook.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

