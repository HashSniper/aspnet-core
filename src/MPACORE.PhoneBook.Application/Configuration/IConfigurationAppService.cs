using System.Threading.Tasks;
using MPACORE.PhoneBook.Configuration.Dto;

namespace MPACORE.PhoneBook.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
