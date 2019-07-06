using Abp.AutoMapper;
using MPACORE.PhoneBook.Authentication.External;

namespace MPACORE.PhoneBook.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
