using Microsoft.AspNetCore.Identity;

namespace HotelManagementApp.Data.Entities
{
    public class AppUser: IdentityUser<Guid>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
