using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace CarManagementAPI.Models.Domain;

public class User:IdentityUser
{
    public Guid Id { get; set; }
    
    [Required, MinLength(3), MaxLength(30)]
    public string FirstName { get; set; }
    
    [Required, MinLength(3), MaxLength(30)]
    public string LastName { get; set; }
    
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    
    public string? ProfilePicture { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
    public Guid FamilyId { get; set; }
    
    public Family Family { get; set; }
}