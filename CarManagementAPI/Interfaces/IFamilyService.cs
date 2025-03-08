using CarManagementAPI.Models;
using CarManagementAPI.Models.Domain;
using CarManagementAPI.Models.DTO;

namespace CarManagementAPI.Interfaces;

public interface IFamilyService
{
    Task<ApiResponse<Family>> CreateFamilyAsync(FamilyDto family);
    Task<ApiResponse<Family>> GetFamilyByIdAsync(Guid id);
}