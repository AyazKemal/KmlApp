using KmlOnline.Presentation.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace KmlOnline.Presentation.Controller;
public sealed class TestController : ApiController
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("İşlem Başarılı");
    }
}
