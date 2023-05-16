using Microsoft.AspNetCore.Mvc;// install from

namespace KmlOnline.Presentation.Abstraction;

[ApiController]
[Route("api/[controller]")]
public abstract class ApiController : ControllerBase
{
}
