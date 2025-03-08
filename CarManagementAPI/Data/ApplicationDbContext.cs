using CarManagementAPI.Models.Domain;
using CarManagementAPI.Services;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarManagementAPI.Data;

public class ApplicationDbContext: IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
        
    }
    
    public DbSet<Family> Families { get; set; }
    
    public DbSet<Car> Cars { get; set; }
    
    public DbSet<ServiceRecord> ServiceRecords { get; set; }
    
    public DbSet<Issue> Issues { get; set; }
    
    public DbSet<Invite> Invites { get; set; }
    
    public DbSet<Image> Images { get; set; }
    
    public DbSet<PasswordResetToken> PasswordResetTokens { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Family>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e=> e.FamilyName).IsRequired();
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasIndex(e => e.VehicleNumber).IsUnique();
            entity.Property(c => c.VehicleNumber).IsRequired();
        });
        
        modelBuilder.Entity<EmailNotification>()
            .Property(e => e.Status)
            .HasConversion<string>();
    }
}