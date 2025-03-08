using System.ComponentModel.DataAnnotations;

namespace CarManagementAPI.Models.Domain;

public class ServiceRecord
{
    public Guid Id { get; set; }
    
    [Required]
    public DateTime ServiceDate { get; set; }
    
    [Required]
    public int MileageAtService { get; set; }
    
    public string? Notes { get; set; }
    
    [Required]
    public DateTime NextServiceDate { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
    public Guid CarId { get; set; }
    
    public Car Car { get; set; }
}