using System.Collections.Generic;
using MPACORE.PhoneBook.Roles.Dto;

namespace MPACORE.PhoneBook.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}