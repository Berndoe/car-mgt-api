namespace CarManagementAPI.Models.Domain;

public class PasswordResetToken
{
    public Guid Id { get; set; } = Guid.NewGuid();
    
    public string Token { get; set; }
    
    public int Otp { get; set; }
    
    public DateTime ExpiryDate { get; set; }
    
    public Guid UserId { get; set; }
}