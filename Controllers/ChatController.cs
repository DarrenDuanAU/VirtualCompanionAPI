using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[controller]")]
public class ChatController : ControllerBase
{
    private readonly IChatService _chatService;

    public ChatController(IChatService chatService)
    {
        _chatService = chatService;
    }

    [HttpPost("send")]
    public async Task<IActionResult> SendMessage([FromBody] ChatRequest request)
    {
        var response = await _chatService.SendMessageAsync(request.UserId, request.Message);
        return Ok(new { reply = response });
    }
}
