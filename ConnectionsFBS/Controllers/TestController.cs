using Microsoft.AspNetCore.Mvc;

namespace ConnectionsFBS.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            return Ok(new {message="Backend Connected Sucessfully"});
        }
    }
}
