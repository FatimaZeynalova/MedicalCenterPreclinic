using Microsoft.AspNetCore.Identity;

namespace MedicalCenterPreclinic.Models
{
    public class User:IdentityUser
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string PhotoPath { get; set; }

    }
}
