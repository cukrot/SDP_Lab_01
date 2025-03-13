using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SDP_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimpleGetAPIController : ControllerBase
    {
        [HttpGet("SimpleGetMethod")]
        public String Get() {
            return $"This is returned by the web API server. Current time is: {DateTime.Now}";
        }
    }
}
