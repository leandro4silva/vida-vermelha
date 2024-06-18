using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace VidaVermelha.Api.Controllers.v1;

[ApiVersion("1.0")]
[Route("v{version:apiVersion}/vidavermelha")]
[ApiController]
public class VidaVermelhaController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { message = "Hello, World!" });
    }
}
