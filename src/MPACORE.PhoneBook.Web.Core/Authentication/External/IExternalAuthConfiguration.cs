using System.Collections.Generic;

namespace MPACORE.PhoneBook.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
