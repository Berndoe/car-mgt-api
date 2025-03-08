using System.Net;
using CarManagementAPI.Data;
using CarManagementAPI.Interfaces;
using CarManagementAPI.Models;
using CarManagementAPI.Models.Domain;
using CarManagementAPI.Models.DTO;

namespace CarManagementAPI.Services;

public class FamilyService : IFamilyService
{
    private readonly ApplicationDbContext _dbContext;
    private readonly ILogger<FamilyService> _logger;
    // private readonly EmailService _emailService;

    public FamilyService(ApplicationDbContext dbContext, ILogger<FamilyService> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
        // _emailService = emailService;
    }

    public async Task<ApiResponse<Family>> CreateFamilyAsync(FamilyDto family)
    {
        try
        {
                var familyRequest = new FamilyDto
                {
                    FamilyName = family.FamilyName
                };
                
                var familyResponse = new Family
                {
                    FamilyName = familyRequest.FamilyName,
                };
                
                await _dbContext.Families.AddAsync(familyResponse);
                await _dbContext.SaveChangesAsync();
                
                _logger.LogInformation("Family Created");
                return new ApiResponse<Family>(true, HttpStatusCode.Created,
                    "Family Created", familyResponse);
        }
        
        catch (Exception e)
        {
            _logger.LogError(e, e.InnerException?.Message);
            return new ApiResponse<Family>(false, HttpStatusCode.InternalServerError,
                "An error occured please try again later");
        }

        return null;
    }

    public async Task<ApiResponse<Family>> GetFamilyByIdAsync(Guid id)
    {
        try
        {
            var family = await _dbContext.Families.FindAsync(id);

            if (family != null) return new ApiResponse<Family>(true, HttpStatusCode.OK,
                "Family Found", family);
            
            _logger.LogInformation("Family Not Found");
            return new ApiResponse<Family>(false, HttpStatusCode.NotFound,"Family Not Found");
        }
        catch (Exception e)
        {
            _logger.LogError(e, e.InnerException?.Message);
            return new ApiResponse<Family>(false, HttpStatusCode.InternalServerError,
                "An error occured please try again later");
        }
    }
}