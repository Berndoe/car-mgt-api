using CarManagementAPI.Enums;

namespace CarManagementAPI.Models.Domain;

public class EmailNotification
{
    public Guid Id { get; set; } = Guid.NewGuid();
    
    public string RecipientEmail { get; set; }
    
    public string Subject { get; set; }
    
    public string Body { get; set; }
    
    public EmailStatus Status { get; set; } = EmailStatus.Unsent;
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime? LastAttemptedDate { get; set; }

    public int RetryCount { get; set; } = 0;
    
    public string? LastErrorMessage { get; set; }
}