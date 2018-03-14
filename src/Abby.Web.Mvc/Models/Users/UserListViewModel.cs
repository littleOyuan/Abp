using System.Collections.Generic;
using Abby.Roles.Dto;
using Abby.Users.Dto;

namespace Abby.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
