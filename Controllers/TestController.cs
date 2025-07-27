using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]  // 或 [Route("api/[controller]")]
public class TestController : ControllerBase
{
    public TestController()
    {
    }

    [HttpPost("send")]
    public async Task<IActionResult> SendMessage([FromBody] ChatRequest request)
    {
        return Ok(new { reply = "hi" });
    }
}
