using System.Collections.Generic;
using MPACORE.PhoneBook.Roles.Dto;

namespace MPACORE.PhoneBook.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
