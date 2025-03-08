using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace CarManagementAPI.Models;

public class ApiResponse<T> : IActionResult
{
    public bool IsSuccess { get; set; }
    public HttpStatusCode StatusCode { get; set; }
    public string Message { get; set; }
    public T Data { get; set; } 

    public ApiResponse(bool isSuccess, HttpStatusCode statusCode, string message, T data = default)
    {
        IsSuccess = isSuccess;
        StatusCode = statusCode;
        Message = message;
        Data = data;
    }

    public async Task ExecuteResultAsync(ActionContext context)
    {
        var response = context.HttpContext.Response;
        response.ContentType = "application/json";
        response.StatusCode = (int)StatusCode;

        // to prevent circular references that would cause a request failure
        var options = new JsonSerializerOptions
        {
            ReferenceHandler = ReferenceHandler.Preserve
        };

        await response.WriteAsync(JsonSerializer.Serialize(this, options));
    }
}