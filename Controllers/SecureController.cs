using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreAuthApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SecureController : ControllerBase
{
    [Authorize]
    [HttpGet("me")]
    public IActionResult GetMyProfile()
    {
        return Ok(new
        {
            Message = "You are authorized with a valid JWT token.",
            User = User.Identity?.Name,
            Claims = User.Claims.Select(claim => new { claim.Type, claim.Value })
        });
    }
}
