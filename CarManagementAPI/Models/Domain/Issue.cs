using System.ComponentModel.DataAnnotations;

namespace CarManagementAPI.Models.Domain;

public class Issue
{
    public Guid Id { get; set; }
    
    [Required]
    public string Description { get; set; }
    
    [Required]
    public string Severity { get; set; }
    
    [Required]
    public string Status { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
    public Guid CarId { get; set; }
    
    public Car Car { get; set; }
}