using System.ComponentModel.DataAnnotations;

namespace CarManagementAPI.Models.Domain;

public class Family
{
    public Guid Id { get; set; }
    
    [Required]
    public string FamilyName { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
}