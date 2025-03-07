using CarManagementAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarManagementAPI.Data;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
        
    }
    
    public DbSet<Family> Families { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Family>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e=> e.FamilyName).IsRequired();
        });
    }
}