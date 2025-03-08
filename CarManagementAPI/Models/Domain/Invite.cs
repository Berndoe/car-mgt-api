using System.ComponentModel.DataAnnotations;

namespace CarManagementAPI.Models.Domain;

public class Invite
{
    public int Id { get; set; }
    
    public string Token { get; set; }
    
    [EmailAddress]
    public string Email { get; set; }
    
    public bool IsAccepted { get; set; }
}