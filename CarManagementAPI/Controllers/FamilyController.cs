using CarManagementAPI.Interfaces;
using CarManagementAPI.Models.Domain;
using CarManagementAPI.Models.DTO;
using CarManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarManagementAPI.Controllers;

[ApiController]
[Route("api/family")]
public class FamilyController
{
    private readonly IFamilyService _familyService;

    public FamilyController(IFamilyService familyService)
    {
        _familyService = familyService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateFamily([FromBody] FamilyDto family)
    {
        return await _familyService.CreateFamilyAsync(family);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetFamily(Guid id)
    {
        return await _familyService.GetFamilyByIdAsync(id);
    }
}