using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MPACORE.PhoneBook.Roles.Dto;
using MPACORE.PhoneBook.Users.Dto;

namespace MPACORE.PhoneBook.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
