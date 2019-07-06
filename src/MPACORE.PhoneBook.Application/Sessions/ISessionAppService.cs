using System.Threading.Tasks;
using Abp.Application.Services;
using MPACORE.PhoneBook.Sessions.Dto;

namespace MPACORE.PhoneBook.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
