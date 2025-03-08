using CarManagementAPI.Interfaces;
using CarManagementAPI.Models;
using CarManagementAPI.Models.Domain;
using CarManagementAPI.Models.DTO;
using Microsoft.AspNetCore.Identity.Data;

namespace CarManagementAPI.Services;

public class UserService : IUserService
{
    public async Task<ApiResponse<User>> RegisterAsync(UserDto userDto)
    {
        throw new NotImplementedException();
    }

    public async Task<ApiResponse<string>> VerifyEmailAsync(string email)
    {
        throw new NotImplementedException();
    }

    public async Task<ApiResponse<bool>> Login(LoginRequest loginRequest)
    {
        throw new NotImplementedException();
    }
}