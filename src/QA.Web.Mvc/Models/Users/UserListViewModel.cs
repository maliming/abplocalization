using System.Collections.Generic;
using QA.Roles.Dto;
using QA.Users.Dto;

namespace QA.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
