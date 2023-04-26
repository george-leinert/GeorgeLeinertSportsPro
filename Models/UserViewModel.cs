using Microsoft.AspNetCore.Identity;

namespace MVCHOT2.Models
{
    public class UserViewModel
    {

        public IEnumerable<User> Users { get; set; } = null!;
        public IEnumerable<IdentityRole> Roles { get; set; } = null!;
    }
}
