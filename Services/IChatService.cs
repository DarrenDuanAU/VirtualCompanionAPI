public interface IChatService
{
    Task<string> SendMessageAsync(string userId, string message);
}
