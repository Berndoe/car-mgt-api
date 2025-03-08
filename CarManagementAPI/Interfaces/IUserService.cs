using CarManagementAPI.Models;
using CarManagementAPI.Models.Domain;
using CarManagementAPI.Models.DTO;
using Microsoft.AspNetCore.Identity.Data;

namespace CarManagementAPI.Interfaces;

public interface IUserService
{
    Task<ApiResponse<User>> RegisterAsync(UserDto userDto);
    
    Task<ApiResponse<string>> VerifyEmailAsync(string email);
    
    Task<ApiResponse<bool>> Login(LoginRequest loginRequest);
}