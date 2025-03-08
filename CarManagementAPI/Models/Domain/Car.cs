using System.ComponentModel.DataAnnotations;

namespace CarManagementAPI.Models.Domain;

public class Car
{
    public Guid Id { get; set; }
    
    [Required]
    public string Make { get; set; }
    
    [Required]
    public string Model { get; set; }
    
    [Required]
    public string VehicleNumber { get; set; }
    
    [Required]
    public int Mileage { get; set; }
    
    public DateTime RoadWorthyExpiryDate { get; set; }
    
    public DateTime InsuranceExpiryDate { get; set; }
    
    public DateTime LastServiceDate { get; set; }
    
    public DateTime NextServiceDate { get; set; }
    
    public string Image { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
    public Guid FamilyId { get; set; }
    
    public Family Family { get; set; }
    
    public ICollection<ServiceRecord> ServiceRecords { get; set; }
    
    public ICollection<Issue> Issues { get; set; }
}