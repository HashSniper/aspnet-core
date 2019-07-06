using System.Collections.Generic;
using MPACORE.PhoneBook.Roles.Dto;
using MPACORE.PhoneBook.Users.Dto;

namespace MPACORE.PhoneBook.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
