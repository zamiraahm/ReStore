using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class User : IdentityUser<int>
    {
         //1 to 1 relationship , 1 user 1 address
        public UserAddress Address { get; set; }
    }
}