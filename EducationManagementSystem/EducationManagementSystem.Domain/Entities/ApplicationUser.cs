using Microsoft.AspNetCore.Identity;

namespace EducationManagementSystem.Domain.Entities;

public class ApplicationUser : IdentityUser
{
    public int ReferenceId {  get; set; }
    public string ApplicationUserName { get; set; }
    public string MobileNumber { get; set; }
    public string UdatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }

}
