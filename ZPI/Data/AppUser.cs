using Microsoft.AspNetCore.Identity;

namespace ZPI.Data;

public sealed class AppUser : IdentityUser
{
    public string? DisplayName { get; set; }
}