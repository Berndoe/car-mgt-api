using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarManagementAPI.Models.Domain;

public class Image
{
    public Guid Id { get; set; }
    
    [Required]
    [NotMapped]
    public IFormFile File { get; set; }
    
    public string FileName { get; set; }
    
    public long FileSize { get; set; }
    
    public string FileExtension { get; set; }
    
    public string FilePath { get; set; }
    
}